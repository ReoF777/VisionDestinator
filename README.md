# VisionDestinator

VisionDestinatorは、画像と質問を元にAIが答えを生成するWinformアプリケーションです。本アプリケーションは、.NET 8上で動作し、OpenAIのAPIを利用して画像と質問からインテリジェントな応答を提供します。

## 機能概要
1. **画像選択**: ユーザーは、アプリ内で任意の画像を選択することができます。
2. **質問入力**: 質問ボックスに、画像に関連する質問を入力します。
3. **AI応答生成**: 選択された画像と入力された質問を元に、AI（GPT-4）モデルが応答を生成します。

## 使用技術
- **プラットフォーム**: .NET 8
- **AIモデル**: GPT-4o（OpenAI APIを通じて使用）
- **ライブラリ**: dotnet-OpenAI

## 動作環境
- .NET 8 ランタイムがインストールされたWindows環境

## インストール方法
1. .NET 8 SDKをインストールします: [.NET 8 ダウンロードページ](https://dotnet.microsoft.com/download/dotnet/8.0)
2. このリポジトリをクローン、もしくはダウンロードします。
3. `dotnet run` コマンドを使用してアプリケーションを起動します。

## 使い方
1. アプリケーションを起動します。
2. 画面上部の「画像選択」ボタンをクリックして、解析したい画像ファイルを選択します。
3. 質問ボックスに質問を入力します。質問は画像に関連したものである必要があります。
4. 「生成」ボタンを押すと、AIが画像と質問をもとに答えを生成します。

## 依存ライブラリ
- [dotnet-OpenAI](https://github.com/openai/openai-dotnet/tree/OpenAI_2.0.0-beta.11): .NETでOpenAIのAPIを利用するためのライブラリです。

## ライセンス
このプロジェクトはMITライセンスの下で提供されています。詳細については、[LICENSE](./LICENSE)ファイルを参照してください。

