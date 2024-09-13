# UnityTerminalLauncher

Unityのプロジェクトフォルダのコンテキストメニューからターミナルを起動するEditor拡張です。

以下のターミナルの起動をサポートしています。

・Windows Terminal
・PowerShell Core
・PowerShell
・コマンドプロンプト
・Git Bash

## 使用方法

### プロジェクトフォルダでターミナルを開く
Window -> External Terminal メニューを選択するとプロジェクトフォルダでターミナルが起動します。

### 選択したフォルダでターミナルを開く
1. Projectウィンドウでフォルダを右クリックします。
2. コンテキストメニューから「Open Terminal Here」を選択すると、選択したフォルダでターミナルが起動します。

### 起動するターミナルを変更する
Edit -> Preferences... メニュー内の Terminal Launcher の項目で起動するターミナルを変更できます。

## 対応OS・動作確認環境

・Windows 10 64-bit
・Unity 2018.4.20f1
・Git for Windows 2.29.2

## 利用規約

本プログラムはMITライセンスで提供されます。LICENSE.txtを参照してください。

## 連絡先

Twitter: https://twitter.com/kurotu

## 更新履歴

・2024/9/13: v2.1.0
　　・asmdefを追加
　　・UPMに対応
　　・Window/External Terminal メニューを追加

・2021/8/21: v2.0.0
　　・UnityGitBashHereから名称変更
　　・Windows Terminal, PowerShell, コマンドプロンプトに対応

・2021/1/14: v1.0.0
　　・公開
