# DGP.Genshin.GamebarWidget
[Snap Genshin](https://github.com/DGP-Studio/Snap.Genshin) Xbox 树脂小组件

## 安装方式
### 1. [下载](https://github.com/DGP-Studio/DGP.Genshin.GamebarWidget/releases) 后解压到任意位置
### 2. 打开文件夹，找到并右键点击如图所示的”安全证书”文件,将其安装到 “本地计算机-受信任的根证书颁发机构” 内
### 如图所示

 ![图片1](https://user-images.githubusercontent.com/52618207/155873173-0000ce31-adce-40dd-827e-51627c53badd.png)
 ![图片2](https://user-images.githubusercontent.com/52618207/155873209-c86df2c4-d240-43b8-a346-db9d004f1104.png)
 ![图片4](https://user-images.githubusercontent.com/52618207/155873397-911e7042-e626-4cd5-962c-64d0ba702b5a.png)
 
### 3. 右键打开 “Install.ps1” 文件，并在 powershell 中运行，即可安装成功。（ win10 和 win11 同理）

 ![图片5](https://user-images.githubusercontent.com/52618207/155873441-ae5caa20-1fb9-4c07-8d46-5c304052cbe8.png)
 
### 4. 在任务栏中应该可以看到新增了 SnapGenshin 小组件字样的项目，运行它。（ win10 和 win11 同理）

 ![图片6](https://user-images.githubusercontent.com/52618207/155873449-926ed83f-5348-4841-91a7-8b80ead24e60.png)

### 5. 最后点击程序内的添加按钮，添加你需要添加的 cookie，即可开始使用。

 ![图片7](https://user-images.githubusercontent.com/52618207/155873480-d8a1392c-162e-45fe-b7ea-49d3ecf2b6c0.png)
 
>使用[Snap Genshin](https://github.com/DGP-Studio/Snap.Genshin)获取过cookie的用户可以打开cookie.dat文件直接复制cookie

## 使用方式
### 使用 WIN+G 组合键，呼出小组件菜单，并点击
![图片8](https://user-images.githubusercontent.com/52618207/155873697-9a0095a8-ad16-42ed-b96e-451ae442944c.png)

## 点击，即可自由拖动位置后使用。

![图片9](https://user-images.githubusercontent.com/52618207/155873753-bc741026-e245-49e1-9d2f-ba82d0b353b9.png)
## 小贴士
![图片10](https://user-images.githubusercontent.com/52618207/155873824-1ffd4de3-d7c2-45f0-b8e9-60c1c1fd2984.png)

## 常见问题
1. 旁加载小组件期间， poweshell 一闪而过
 - **管理员运行** poweshell ，输入 set-executionpolicy remotesigned 命令，更改策略并**顺势打开开发者模式**即可

2. 添加 cookie 后提示 此小组件有问题
   ### **目前只要打开 Snap Genshin 树脂小组件主窗口均会提示 _“此小组件有问题”_**
 - 关闭主窗口后使用 win+G 关闭小组件再重新打开即可解决
 
3. 树脂小组件不显示任何文本
 - 多等待一会或尝试关闭后重新打开小组件
 - 请检查是否开启了代理软件
   - clash 用户可以从 General 页面下的 UWP Loopback 中勾选 Snap Genshin Resin 后点击 Save Changes 即可
 - 检查是否开启了米游社实时便笺权限 
4. 小组件树脂提示不准确
 - 检查米游社的实时便笺内树脂显示是否正确
 - 树脂小组件每八分钟刷新一次数据，数据会有延迟
