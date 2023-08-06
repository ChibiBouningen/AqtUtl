# AqtUtl  -AquesTalkPlayerとAviUtlを連携で使いやすく！-  
<img width="100%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/4aa5aa74-50ae-4888-b7ff-84d351e3bdcf"><br>  
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
- [動作要件](#動作要件)  
- [質問・バグ報告](#質問・バグ報告)  
- [使用させて頂いた物](#使用させて頂いた物)  

# 導入方法  
## 事前準備  
もしAviUtlにpatch.aul(https://github.com/ePi5131/patch.aul)を導入していなければ導入してください。  

## インストール  
1. [Release](https://github.com/ChibiBouningen/AqtUtl/releases)からAqtUtlの最新版をダウンロード  
<b>セキュリティソフトにより、ダウンロードしたAqtUtlのファイルが削除されてしまう場合があります。例外設定を行った後に再度ダウンロードしてください。</b>
1. AquesTalkPlayerの最新版を[公式サイト](https://www.a-quest.com/products/aquestalkplayer.html)からダウンロード  
1. ダウンロードいたAqtUtlとAquesTalkPlayerを解凍し、AqtUtl.exeの入ったフォルダにAquesTalkPlayerの入ったフォルダ「aquestalkplayer」をコピーする  
1. AqtUtl.exeを起動する  
1. 「ツール」→「設定」から、AviUtlのプロジェクトに合わせてFPS(フレームレート)を設定する  
導入に成功していれば、AqtUtlのツール→AquesTalkPlayerを起動 よりAquesTalkPlayerが起動できます。  
<br>

## 古いバージョンから更新する場合  
AqtUtl.exeを新しいバージョンに置き換えてください。  
<br>
# 使い方  
プロファイルを指定し、"字幕"の入力欄に文字を入力、「クリックで音声を生成」という部分をクリックすると音声の再生・生成が始まります。  
すぐに「ここをD&Dしてください」という表示に切り替わるので、グレーになっている部分をそのままAviUtlの拡張編集にドラッグアンドドロップすると音声(及び設定していれば字幕)が現れます。  
字幕と読みを別々にしたい場合、「字幕をコピー」にチェックを入れると"発音記号"の入力欄に発音を別で入力することができます。  

AqtUtlでは、AquesTalkPlayerを用いて音声を生成しています。そのため、辞書登録や音声プリセットの作成はAquesTalkPlayer側にて行う必要があります。  

## プロファイルの設定  
事前にAquesTalkPlayerにてオンラインマニュアル(https://www.a-quest.com/products/aquestalkplayer_man.html)  
に従い、使用したい音声のプリセットを作成してください。  
<img src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/b6223e50-5c12-4912-b884-d489ee3ba834"><br>
画面左側を右クリックし、「プロファイルを新規作成」をクリックすると、新しいプロファイルを作成します。  
既存のプロファイルを右クリックし「プロファイルを編集」をクリックすると、そのプロファイルを編集することができます。  
「プロファイルの設定」というウィンドウが開きます。  
<img src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/76c736d6-96b9-4c16-85b0-5865cb41b269"><br>
「プロファイル名」には任意のプロファイル名  
「AquesTalkPlayerのプリセット名」には、AquesTalkPlayerで設定したプリセットの名前を入力します。  
「並べ替えの優先度」は、数字が大きいほどプロファイルがAqtUtl内で上位に表示されます。  
「音声の長さ補正」は、AviUtlに音声(と字幕)を出力する際、長さを指定したフレーム数分伸ばします。  
「字幕を付与」の項目は[字幕の設定方法](#字幕の設定方法)にて解説しています。  
作成(もしくは適用)ボタンを押すと、設定した内容が反映され、新規作成の場合は設定したプロファイルが選択できるようになっています。  
<br>

## 字幕の設定方法  
プロファイルごとに字幕を設定することができます。  
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

## AqtUtlの設定  
「ツール」→「設定」からAqtUtl全体に関係する設定を変更することができます。  
「音声出力パス」には音声とexoファイルを出力するフォルダを絶対パスで指定します。但しoutputと設定した場合はAqtUtl.exeと同じフォルダのoutputフォルダに出力されます。  
「AviUtlのFPS」には、AviUtlで編集するプロジェクトのフレームレートを記述してください。  
「起動時「字幕をコピー」にチェックを入れる」はそのままです。  
<br>

# 動作要件
- CPU x86系 (ARM系は検証環境がないので保障できません)  
- OS Windows10 64bit 1909以降  
- AviUtl 1.10  
- 拡張編集プラグイン 0.92  
- [patch.aul](https://github.com/ePi5131/patch.aul) r42以降  
- AquesTalkPlayer Ver.1.0.1.1以降  
<br>

# 質問・バグ報告  
[GitHubのIssues](https://github.com/ChibiBouningen/AqtUtl/issues)にて受け付けております。  
<br>

# 使用させて頂いた物 
- NAudio  
	https://github.com/naudio/NAudio  
	MIT license  
- Fody Costura  
	https://github.com/Fody/Costura  
	MIT license  
