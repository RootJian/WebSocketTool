# WebSocketTool
#### Websocket通讯使用：[Websocket-Sharp](http://sta.github.io/websocket-sharp/#websocket-client)
#### JSON解析使用：[Newtonsoft.Json.12.0.3](https://www.newtonsoft.com/json)
支持ws,wss服务。<br/>
已打包的安装程序：[WebSocketTool下载](https://raw.githubusercontent.com/RootJian/WebSocketTool/master/WebSocketToolSetup.msi)（GitHub连接可能会抽风，拉取项目后也有安装程序）<br />
该程序用于开发者调试websocket接口使用，不带压力测试功能。

-----
>2020/6/2更新 V1.0.0<br />
>1、新增WebSocket断开提示；<br />
>2、新增JSON解析自动结构化；<br />
>3、新增设置，配置服务器地址路径；<br />
>4、新增自动记忆上次Api路径；<br />
>5、修复按钮逻辑问题；<br />
-----
## 预览
![](https://raw.githubusercontent.com/RootJian/WebSocketTool/master/preview.jpg)
## 说明
1、第一版本中，路径过长操作不方便，且需要每次重新输入。本次更新在设置中可配置服务器地址并保存，在测试页面仅需要输入API地址即可。例：完整地址ws://localhost:8080/api/ws和ws://localhost:8080/api/ws1，可在设置中配置好ws://localhost:8080/api，在测试页面键入/ws1或/ws即可。<br />
2、向服务器发送数据时，如为json数据可点击JSON勾选框进行自动json格式化。