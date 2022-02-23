using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.Serialization.Json;

namespace MC_DTG
{
    public partial class MainForm : Form
    {
        private bool FirstTime = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            FirstTime = false;
        }

        public class Datapack
        {
            public string Name = "";
            public string Namespace = "";
            public int PackFormat = 0;
            public string Description = "";
        }

        [System.Runtime.Serialization.DataContract]
        public class Pack
        {
            [System.Runtime.Serialization.DataMember()]
            public int Pack_format { get; set; }

            [System.Runtime.Serialization.DataMember()]
            public string Description { get; set; }
        }

        [System.Runtime.Serialization.DataContract]
        public class MCMeta
        {
            [System.Runtime.Serialization.DataMember()]
            public Pack Pack { get; set; }
        }

        [System.Runtime.Serialization.DataContract]
        public class Json
        {
            [System.Runtime.Serialization.DataMember()]
            public List<string> Values { get; set; }
        }

        private readonly Datapack datapack = new Datapack();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            if (VersionComboBox.SelectedIndex == -1) VersionComboBox.SelectedIndex = VersionComboBox.Items.Count - 1;
            CreatePack();
        }

        private void CreatePack()
        {
            try
            {
                //データセット
                datapack.Name = NameTextBox.Text;
                datapack.Namespace = NamespaceTextBox.Text;
                datapack.Description = DescriptionTextBox.Text;
                _ = int.TryParse(VersionComboBox.SelectedItem.ToString()[0].ToString(), out datapack.PackFormat);

                bool isEnd = false;
                if (datapack.Name == "")
                {
                    _ = MessageBox.Show("エラーが発生しました\nデータパック名の入力に不備があります");
                    isEnd = true;
                }
                else if (datapack.Namespace == "")
                {
                    _ = MessageBox.Show("エラーが発生しました\n名前空間の入力に不備があります");
                    isEnd = true;
                }
                else if (DirectoryTextBox.Text == "")
                {
                    _ = MessageBox.Show("エラーが発生しました\n保存場所の入力に不備があります");
                    isEnd = true;
                }
                if (isEnd) return;
                
                //:保存先
                var path = $"{DirectoryTextBox.Text}\\{datapack.Name}";
                _ = Directory.CreateDirectory(path);

                //:保存先\<データパック名>
                var pack = new Pack()
                {
                    Pack_format = datapack.PackFormat,
                    Description = datapack.Description
                };
                var mcmeta = new MCMeta()
                {
                    Pack = pack
                };
                CreateFile(path, "pack.mcmeta", typeof(MCMeta), mcmeta);
                path += "\\data";

                //:保存先\<データパック名>\data
                var path_minecraft = $"{path}\\minecraft\\tags\\functions";
                var path_namespace = $"{path}\\{datapack.Namespace}";
                _ = Directory.CreateDirectory(path_minecraft);
                _ = Directory.CreateDirectory(path_namespace);

                //:保存先\<データパック名>\data\minecraft\tags\functions
                var strings = new string[2]
                {
                    "load","tick"
                };
                foreach (var s in strings)
                {
                    var list = new List<string>()
                    {
                        $"{datapack.Namespace}:{s}"
                    };
                    var json = new Json()
                    {
                        Values = list
                    };
                    CreateFile(path_minecraft, $"{s}.json", typeof(Json), json);
                }

                //:保存先\<データパック名>\data\<名前空間>
                var namespace_under = new string[11]
                {
                    "advancements","functions","item_modifiers","loot_tables","predicates","recipes","structures","tags","dimension_type","dimension","worldgen"
                };
                foreach (string s in namespace_under)
                {
                    _ = Directory.CreateDirectory($"{path_namespace}\\{s}");
                }

                //:保存先\<データパック名>\data\<名前空間>\tags
                var path_tags = $"{path_namespace}\\tags";
                var tags_under = new string[5]
                {
                    "blocks","entity_types","fluids","functions","items"
                };
                foreach (string s in tags_under)
                {
                    _ = Directory.CreateDirectory($"{path_tags}\\{s}");
                }

                //:保存先\<データパック名>\data\<名前空間>\worldgen
                var path_worldgen = $"{path_namespace}\\worldgen";
                var worldgen_under = new string[8]
                {
                    "biome","configured_carver","configured_feature","configured_structure_feature","configured_surface_builder","noise_settings","processor_list","template_pool"
                };
                foreach (var s in worldgen_under)
                {
                    _ = Directory.CreateDirectory($"{path_worldgen}\\{s}");
                }

                _ = MessageBox.Show("生成が正常に完了しました");
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show($"エラーが発生しました\n{ex}");
                return;
            }
        }

        private void CreateFile(string path, string name, Type type, dynamic dynamic)
        {
            //使い方:CreateFile(path,name,typeof(Type),text);
            //path:フォルダパス
            //name:ファイル名
            //typeof(Type):データタイプ
            //text:テキストデータ
            using (var fs = new FileStream($"{path}\\{name}", FileMode.Create))
            using (var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, true, true, "    "))
            {
                var serializer = new DataContractJsonSerializer(type);
                serializer.WriteObject(writer, dynamic);
            }
        }

        private void DirectoryButton_Click(object sender, EventArgs e)
        {
            if (!FirstTime)
            {
                FirstTime = true;
                using (var cofd = new CommonOpenFileDialog()
                {
                    Title = "フォルダを選択してください",
                    InitialDirectory = Directory.GetCurrentDirectory(),
                    IsFolderPicker = true,
                })
                {
                    if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
                    {
                        return;
                    }
                    DirectoryTextBox.Text = cofd.FileName;
                }
            }
            else
            {
                using (var cofd = new CommonOpenFileDialog()
                {
                    Title = "フォルダを選択してください",
                    RestoreDirectory = true,
                    IsFolderPicker = true,
                })
                {
                    if (cofd.ShowDialog() != CommonFileDialogResult.Ok)
                    {
                        return;
                    }
                    DirectoryTextBox.Text = cofd.FileName;
                }
            }
        }
    }
}
