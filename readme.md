# AqtUtl  -AquesTalkPlayerとAviUtlを連携で使いやすく！-  
<img width="100%" src="https://github.com/ChibiBouningen/AqtUtl/assets/84241001/4aa5aa74-50ae-4888-b7ff-84d351e3bdcf"><br>  
AquesTalkPlayerの音声とAviUtlの字幕を同時に生成し、動画作成を支援するツールです。  
[mikado394m様のYukkuriUtil](https://github.com/mikado394m/yukkuriutil1)に近い機能を持ちます。YukkuriUtilの依存ソフトであるSoftalkがAquesTalkのサポートを終了したためAqtUtlを作成しました。  

## 目次  
- [事前準備](#事前準備)  
- [導入方法](#導入方法)  
  - [字幕の設定方法](#字幕の設定方法)  
- [動作要件](#動作要件)  
- [質問・バグ報告](#質問・バグ報告)  
- [使用させて頂いた物](#使用させて頂いた物)  

## 事前準備  
もしAviUtlに[patch.aul](https://github.com/ePi5131/patch.aul)を導入していなければ導入してください。  

## 導入方法  
1. [Release](https://github.com/ChibiBouningen/AqtUtl/releases)から最新版をダウンロード  
1. AquesTalkPlayerの最新版をダウンロード  
1. ダウンロードいたAqtUtlとAquesTalkPlayerを解凍し、AqtUtl.exeの入ったフォルダにAquesTalkPlayerの入ったフォルダ「aquestalkplayer」をコピーする  
1. AqtUtl.exeを起動する  
1. ツール→設定から、AviUtlのプロジェクトに合わせてFPS(フレームレート)を設定する  
導入に成功していれば、AqtUtlのツール→AquesTalkPlayerを起動 よりAquesTalkPlayerが起動できます。  

## 使い方  
キャラクタ プロファイルを指定し字幕に文字を入力、「クリックで音声を生成」という部分をクリックすると生成が始まります。  
すぐに「ここをD&Dしてください」という表示に切り替わるので、グレーになっている部分をそのままAviUtlの拡張編集にドラッグアンドドロップすると音声(及び設定していれば字幕)が現れます。  
  
画面左側を右クリックすると、キャラクタプロファイルの作成・編集が可能です。  
利用したいAquesTalkPlayerのプリセット名を設定すると、プロファイル利用時に設定したプリセットの音声で出力されます。  
出力された音声およびexoファイルはデフォルトでAqtUtl.exeと同じ位置にあるoutputフォルダに出力されます。この設定はツール→設定にて変更できます。  

## 字幕の設定方法  
キャラクタ プロファイルごとに字幕を設定することができます。  
1. AviUtlを起動しプロジェクトを新規に作成する。  
1. 字幕を設定したいキャラクタ プロファイルを使って一度適当な音声を作り拡張編集に投げる。  
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
1. AqtUtlに戻り、字幕を設定したいキャラクタ プロファイルを編集する。  
1. 「字幕を付与」にチェックを入れる。  
1. 下のテキストボックスにexoファイルの中身をペーストし、「適用」を押す。  

設定が完了したら、字幕が正しく表示されるかを確認してください。  


## 動作要件
- CPU x86系 (ARM系は検証環境がないので保障できません)  
- OS Windows10 64bit 1909以降  
- AviUtl 1.10  
- 拡張編集プラグイン 0.92  
- [patch.aul](https://github.com/ePi5131/patch.aul) r42以降  
- AquesTalkPlayer Ver.0.9.3.1以降  

## 質問・バグ報告  
[GitHubのIssues](https://github.com/ChibiBouningen/AqtUtl/issues)にて受け付けております。  

## 使用させて頂いた物 
- NAudio  
	https://github.com/naudio/NAudio  
	MIT license  
- Fody Costura  
	https://github.com/Fody/Costura  
	MIT license  
