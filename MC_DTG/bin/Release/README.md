# MC_DTG
MineCraftJavaEdition用のデータパックのテンプレートを生成するWindows用アプリケーション

## はじめに
C#のフォームアプリ開発の勉強用にと作ったアプリケーションです
<br>
せっかくだから配布してみようと思ったので...

## 何ができる？
データパック名・名前空間・対応バージョン・説明・保存場所の情報を入力(設定)すると、
<br>
データパックに必要なファイル・フォルダのほとんどを生成してくれます
<br>
説明は省略できます
<br>
以下、生成されるフォルダ・ファイル一覧(v1.0.0)
- データパック名
  - pack.mcmeta
  - data
    - minecraft/tags/functions
      - load.json
      - tick.json
    - 名前空間
      - advancements
      - dimensions
      - dimension_type
      - functions
      - item_modifiers
      - loot_tables
      - predicates
      - recipes
      - structures
      - tags
        - blocks
        - entity_types
        - fluids
        - functions
        - items
      - worldgen
        - biome
        - configured_carver
        - configured_feature
        - configured_structure_feature
        - configured_surface_builder
        - noise_settings
        - processor_list
        - template_pool
## 使い方
1. zipファイルをダウンロードして展開
2. MC_DTG.exeを開く
3. 情報を入力(設定)
4. 実行ボタンを押す
5. 生成されたフォルダ・ファイルを編集してデータパックをつくろう

## 注意事項
- exeファイルを移動しないでください
  <br>
  正常な動作ができない可能性があります
  <br>
  ショートカットの作成及びピン止め等の対処をお願いします
- 説明はjson形式には対応していません
  <br>
  ご自身でVSCode等のテキストエディタでの編集をしてください
- これはデータパックの基本を作るアプリです
  <br>
  生成されたものをMinecraftに入れても何もありませんよ
- **あくまで個人の趣味です**
  <br>
  そう、趣味なんですよ
  <br>
  クオリティ？多言語対応？すまん、そこまでやる気にはならなかった

## その他
制作者 にゃもしゃん
<br>
Twitter [@akatukikyuto_](https://twitter.com/akatukikyuto_)
<br>
バグ報告とか [Issues](https://github.com/Nyamosyan/MC_DTG/issues)