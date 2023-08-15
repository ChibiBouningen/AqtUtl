﻿# AqtUtl  -AquesTalkPlayerとAviUtlを連携で使いやすく！-  
<img width="60%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/38a3febc-b60c-4c33-9d10-0a4e1489bcc8"><br>  
音声合成ソフトのAquesTalkPlayerと動画編集ソフトのAviUtlを連携させ、動画作成を支援するツールです。  
[mikado394m様のYukkuriUtil](https://github.com/mikado394m/yukkuriutil1)に近い機能を持ちます。YukkuriUtilの依存ソフトであるSoftalkがAquesTalkのサポートを終了したためAqtUtlを作成しました。  

# 目次  
- [導入方法](#事前準備)  
  - [事前準備](#事前準備)
  - [インストール](#導入方法)  
- [使い方](#使い方)
  - [プロファイルの設定](#プロファイルの設定)  
  - [字幕の設定方法](#字幕の設定方法)  
  - [AqtUtlの設定](#aqtutlの設定)  
  - [ショートカットキー](#ショートカットキー)
- [1クリック挿入機能を使う](#1クリック挿入機能を使う)
- [PSDToolkitとの連携(上級者向け)](#psdtoolkitとの連携上級者向け)
- [動作要件](#動作要件)  
- [質問・要望・バグ報告](#質問・要望・バグ報告)  
- [使用させて頂いた物](#使用させて頂いた物)  

# 導入方法  
### 事前準備  
もしAviUtlに[patch.aul](https://github.com/ePi5131/patch.aul)を導入していなければ導入してください。  

### インストール  
1. [Release](https://github.com/ChibiBouningen/AqtUtl/releases/latest)からAqtUtlの最新版をダウンロードする  
<b>セキュリティソフトにより、ダウンロードしたAqtUtlのファイルが削除されてしまう場合があります。適宜例外設定を行ってください。</b>
1. AquesTalkPlayerの最新版を[公式サイト](https://www.a-quest.com/products/aquestalkplayer.html)からダウンロード  
1. ダウンロードしたAqtUtlとAquesTalkPlayerを解凍する  
1. AqtUtl.exeの入ったフォルダにAquesTalkPlayerの入ったフォルダ「aquestalkplayer」をコピーする  
画像のようになっていればOK  
<img width="60%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/e706937c-bcd7-4322-8f71-f01e9b087aff"><br>  
1. AqtUtl.exeを起動する  
1. 「ツール」→「設定」から、AviUtlのプロジェクトに合わせてFPS(フレームレート)を設定する  

導入に成功していれば、AqtUtlのツール→AquesTalkPlayerを起動 よりAquesTalkPlayerが起動できます。  
<br>

### 古いバージョンから更新する場合  
AqtUtl.exeを新しいバージョンに置き換えてください。  
<br>

# 使い方  
プロファイルを指定し、"字幕"の入力欄に文字を入力、「音声を生成」という部分をクリックすると音声の再生・生成が始まります。  
すぐに「ここをD&Dしてください」という表示に切り替わるので、グレーになっている部分をそのままAviUtlの拡張編集にドラッグアンドドロップすると音声(及び設定していれば字幕)が現れます。  
字幕と読みを別々にしたい場合、「字幕をコピー」にチェックを入れると"発音記号"の入力欄に発音を別で入力することができます。  

AqtUtlでは、AquesTalkPlayerを用いて音声を生成しています。そのため、<span style="color: red; ">辞書登録や音声プリセットの作成はAquesTalkPlayer側にて行う必要があります</span>。 



### プロファイルの設定  
事前にAquesTalkPlayerにて[AquesTalkPlayerのオンラインマニュアル](https://www.a-quest.com/products/aquestalkplayer_man.html)に従い、使用したい音声のプリセットを作成してください。  
<br>
<img src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/47464882-e0e6-4cdc-8610-40aa80312391"><br>
画面左側を右クリックし、「プロファイルを新規作成」をクリックすると、新しいプロファイルを作成します。  
既存のプロファイルを右クリックし「プロファイルを編集」をクリックすると、そのプロファイルを編集することができます。  
「プロファイルの設定」というウィンドウが開きます。  
<img src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/f75de3fb-1477-4c7c-8bd7-acd546d9be29"><br>
「プロファイル名」には任意のプロファイル名  
「AquesTalkPlayerのプリセット名」には、AquesTalkPlayerで設定したプリセットの名前を入力します。  
「音声の長さ補正」は、AviUtlに音声(と字幕)を出力する際、長さを指定したフレーム数分伸ばします。  
「挿入するレイヤー」は、後述する[1クリック挿入機能](#1クリック挿入機能を使う)の有効時に音声を挿入するレイヤーを指定します。    
「字幕を付与」の項目は[字幕の設定方法](#字幕の設定方法)にて解説しています。  
作成(もしくは適用)ボタンを押すと、設定した内容が反映され、新規作成の場合は設定したプロファイルが選択できるようになっています。  
<br>

### 字幕の設定方法  
プロファイルごとに字幕を設定することができます。  
ゆくサクとほぼ同じ方法で登録することができます。  
1. AviUtlを起動しプロジェクトを新規に作成する。  
1. 字幕を設定したいプロファイルを使って一度適当な音声を作り拡張編集に投げる。  
1. 音声を拡張編集のレイヤー1に移動する。  
1. 拡張編集でテキストオブジェクトを作り、レイヤー2に配置する。始点と終点を先ほどの音声に合わせる。  
1. テキストオブジェクトと音声をグループ化する。  
1. テキストオブジェクトを編集し、字幕になるよう好きなように編集する。  
1. 完成したら、拡張編集を右クリックしファイル→オブジェクトファイルのエクスポートを選択、適当なところにexoファイルを保存する。  
1. 保存したexoファイルをメモ帳で開く。  
1. [0]より上にある文字を全て消す。  
1. [0]の中3行目付近にあるend=の右にある数字を消し、{2}と書き換える(end={2}となっていればOK)。  
1. 少し下にあるfile=の右にある文字列を消し、{1}と書き換える(file={1}となっていればOK)。  
1. [1]にあるend=の右にある数字を消し、{2}と書き換える(end={2}となっていればOK)。  
1. [1.0]にあるtext=の右にある文字列を消し、{0}と書き換える(text={0}となっていればOK)。  
1. 書き換えたexoファイルの中身の文字列を全てコピーする。  
1. AqtUtlに戻り、字幕を設定したいプロファイルを編集する。  
1. 「字幕を付与」にチェックを入れる。  
1. 下のテキストボックスにexoファイルの中身をペーストし、「適用」を押す。  

設定が完了したら、字幕が正しく表示されるかを確認してください。  
<br>

### AqtUtlの設定  
<img width="30%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/51c08d7b-cfdf-44fe-bcc0-7403da0f83f2"><br>  
「ツール」→「設定」からAqtUtl全体に関係する設定を変更することができます。  
「音声出力パス」には音声とexoファイルを出力するフォルダを指定します。￥から記述するとAqtUtl.exeからの相対パスで記述することができます。  
「AviUtlのFPS」には、AviUtlで編集するプロジェクトのフレームレートを記述します。  
「起動時「字幕をコピー」にチェックを入れる」はそのままです。  
「ごちゃまぜドロップスと連携」は[1クリック挿入機能を使う](#1クリック挿入機能を使う)をご確認ください。  
「常に最前面に表示」にチェックを入れると、AqtUtlが他のアプリの裏に隠れず、常に最前面に表示されるようになります。  

<br>

### ショートカットキー  
AqtUtlの主要な操作にはショートカットキーが割り振られています。  
<img width="100%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/c4495e48-a812-4a92-b565-0722a6423bcd"><br>  
| 動作 | 割り当てキー |
|:-----------|:------------|
| 1つ上のプロファイルを選択 | Ctrl + Shift + I |
| 1つ下のプロファイルを選択 | Ctrl + Shift + K |
| 字幕入力欄にフォーカス | Ctrl + Shift + O |
| 発音入力欄にフォーカスし、字幕をコピーのチェックを外す | Ctrl + Shift + L |
| 字幕をコピーのチェックを切り替える | Ctrl + Shift + M |
| 音声を試聴する | F5 |
| 音声を生成(もしくは拡張編集に挿入) | Ctrl + Insert |

現状ユーザーによってショートカットをカスタマイズする機能の実装は予定していません。メニューを作るのが面倒で...。  
カスタマイズできるようにするPR待ってます。  
<br>

# 1クリック挿入機能を使う  
oov氏の公開しているAviUtlプラグイン[「ごちゃまぜドロップス」](https://github.com/oov/aviutl_gcmzdrops)の外部連携APIを使用して、１クリックで拡張編集タイムラインに音声や字幕を投入することができます。  
ショートカットキーを同時に活用するとキーボード操作のみで次々と音声字幕を挿入していくことができるので、動画作成をより高速に行うことができます。  
ごちゃまぜドロップスとの連携は自作の連携用CLIアプリ[gcmzAPI.exe](https://github.com/ChibiBouningen/gcmzAPIexe)を呼び出すことで実現します。  
<img width="60%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/f74a162e-0ff6-46c1-8d9f-e8c5649b8249"><br>  

### 導入方法  
1. [Visual C++再頒布可能パッケージ](https://learn.microsoft.com/ja-jp/cpp/windows/latest-supported-vc-redist?view=msvc-170)のVisualStudio2022 x64向けのものをダウンロードし、インストールする  
<img width="60%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/d6622fb4-114e-406c-86ee-4bbb8a8c2119"><br>
画像の赤丸のところからダウンロードし、インストールする  
1. ごちゃまぜドロップスとの連携に必要な[gcmzAPI.exeの最新版をダウンロード](https://github.com/ChibiBouningen/gcmzAPIexe/releases/latest)  
<img width="60%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/ef1151c1-92b9-4473-b7f9-377f77ea79c4"><br>
1. AqtUtl.exeと同じ場所にgcmzAPI.exeを配置  
1. AqtUtlを起動し、「ツール」→「設定」→「ごちゃまぜドロップスと連携」にチェックを入れ、設定ウィンドウを閉じる  

### 使用方法  
ごちゃまぜドロップスを導入したAviUtl起動し、<span style="color: red; ">必ずプロジェクトを開いた状態で</span>「拡張編集に挿入」をクリックします。  
音声の生成が完了した後、プロファイルに設定した音声と字幕がAviUtl拡張編集タイムラインの再生位置に挿入されます。  
この時挿入されたオブジェクトの長さ分再生位置が移動します。  
挿入するレイヤーは「プロファイルの編集」の「挿入するレイヤー」によって指定することができます。  

### うまく動かない！  
挿入するレイヤーと再生位置にすでにオブジェクトが存在すると音声を挿入できません。  
AviUtlで必ずプロジェクトを作成してください。
プロジェクトを開かず挿入操作を行うと「拡張編集に挿入しました」という表示になりますが実際には挿入できません。  
連続で同じ内容を挿入しようとすると10秒ほどかかる現象を確認しています。  

# PSDToolkitとの連携(上級者向け)  
PSDToolkitを使用したことがある方向けの内容です。導入方法等の説明は割愛させていただきます。  
1. AqtUtlにて、[字幕の設定方法](#字幕の設定方法)に従い字幕を設定したプロファイルを作成する  
1. PSDToolkit環境設定の発動条件→1フレーム目に音声とテキストがある *.exoをドロップした時 にチェックを入れる  
1. PSDToolkitにてpsdや字幕音声、口パクの設定を行う  

ことにより、AqtUtlから音声を挿入すると字幕や口パクが動くようになります。  

# 動作要件
- CPU x86系 (ARM系は検証環境がないので保障できません)  
- OS Windows10 64bit 1909以降  
- AviUtl 1.10  
- 拡張編集プラグイン 0.92  
- [patch.aul](https://github.com/ePi5131/patch.aul) r42以降  
- AquesTalkPlayer Ver.1.0.1.1以降  

1クリック挿入機能有効時には追加で  
- ごちゃまぜドロップス v0.3.25以上  

が必要です。
<br>

# 質問・要望・バグ報告  
[GitHubのIssues](https://github.com/ChibiBouningen/AqtUtl/issues)にて受け付けております。  
その他[作者X](https://twitter.com/tiisanapeople)や動画サイトのコメント欄でお気軽にどうぞ。  
<br>

# 使用させて頂いた物 
- NAudio  
	https://github.com/naudio/NAudio  
	MIT license  
- Fody Costura  
	https://github.com/Fody/Costura  
	MIT license  
