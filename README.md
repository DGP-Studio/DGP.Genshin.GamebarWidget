# DGP.Genshin.GamebarWidget
[Snap Genshin](https://github.com/DGP-Studio/Snap.Genshin) Xbox 树脂小组件

## 安装
 1. [下载](https://github.com/DGP-Studio/DGP.Genshin.GamebarWidget/releases) 后解压到任意位置

2. 在解压后的文件夹内，找到拓展名为`pfx`的安全证书文件

   1. 双击打开，点击`安装证书`

   2. 储存位置选择`本地计算机` ![图片2](https://user-images.githubusercontent.com/52618207/155873209-c86df2c4-d240-43b8-a346-db9d004f1104.png)

   3. 证书储存选择`将所有的证书都放入下列储存`，位置选择为`受信任的根证书颁发机构`

      ![图片4](https://user-images.githubusercontent.com/52618207/155873397-911e7042-e626-4cd5-962c-64d0ba702b5a.png)

   4.  右键选中 `Install.ps1` 文件，选择在 PowerShell 中运行，并按照提示操作即可安装成功

       ![图片5](https://user-images.githubusercontent.com/52618207/155873441-ae5caa20-1fb9-4c07-8d46-5c304052cbe8.png)

   5. 此时你通过Windows的搜索工具即可找到该组件程序    

   6. 打开程序，添加你的米游社帐号

      1. 你可以点击程序内右下角的添加按钮，添加帐号的 cookie后即可开始使用 
      2. 使用[Snap Genshin](https://github.com/DGP-Studio/Snap.Genshin)获取过cookie的用户可以打开`cookie.dat`文件直接复制cookie

      ![图片7](https://user-images.githubusercontent.com/52618207/155873480-d8a1392c-162e-45fe-b7ea-49d3ecf2b6c0.png)

## 使用
1. 使用` WIN+G `组合键，呼出Xbox小组件菜单，并点击

   ![图片8](https://user-images.githubusercontent.com/52618207/155873697-9a0095a8-ad16-42ed-b96e-451ae442944c.png)

2. 点击`Snap Genshin树脂小组件`后，即可自由拖动位置后使用

![图片9](https://user-images.githubusercontent.com/52618207/155873753-bc741026-e245-49e1-9d2f-ba82d0b353b9.png)
## 小贴士
![图片10](https://user-images.githubusercontent.com/52618207/155873824-1ffd4de3-d7c2-45f0-b8e9-60c1c1fd2984.png)

## 常见问题
- 旁加载小组件期间， PowerShell 一闪而过
  - **以管理员身份运行** PowerShell ，输入 `set-executionpolicy remotesigned` 命令，更改策略并**打开开发者模式**即可
- 添加 cookie 后提示 此小组件有问题
  - 目前只要打开 Snap Genshin 树脂小组件主窗口均会提示 `此小组件有问题`
  - 关闭主窗口后使用 `win+G `关闭小组件再重新打开即可解决
- 树脂小组件不显示任何文本
  - 多等待一会或尝试关闭后重新打开小组件
  - 请检查是否开启了代理软件
    - clash 用户可以从 General 页面下的 `UWP Loopback` 中勾选 `Snap Genshin Resin` 后点击 Save Changes 即可
  - 检查是否开启了米游社实时便笺权限 
- 小组件树脂提示不准确
  - 检查米游社的实时便笺内树脂显示是否正确
  - 树脂小组件每八分钟刷新一次数据，数据会有延迟
