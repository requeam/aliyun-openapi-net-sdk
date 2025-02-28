### 2019-06-06 Version 1.3.6
* Code clean up to fit in with .net coding convention
* Add support for build .net framework4.5 on linux

### 2019-05-22 Version 1.3.5
* Fix net45 not support error

### 2019-05-20 Version 1.3.4
* Fix regex unescape error
* Fix assembly version miss error

### 2019-04-18 Version 1.3.2
* Add support framework from net45 to netstandard2.0 in one nuget package

### 2019-04-16 Version 1.3.1
* Fix '\u' unescape character resolve error when parse http response content

### 2019-04-15 Version 1.3.0
* Add support target net45 reference 

### 2019-04-12 Version 1.2.9
* Ini file resolve refactor
* Support .net framework 461 in Visual Studio 2015
* Support generic method in DictionaryUtil

### 2019-04-04 Version 1.2.8
* Add support for RamRoleCredential Policy
* Add support for Credential chains

### 2019-04-01 Version 1.2.7
* Add support for log
* Core code refactor

### 2019-03-22 Version 1.2.6
* Refactor http proxy
* Method accessibility improve

### 2019-03-21 Version 1.2.5
* Add support for http proxy

### 2019-03-15 Version 1.2.4
* Add support for ignoring https certificate

### 2019-03-14 Version 1.2.3
* Add support for bearertoken
* Add support for timeout
* Improve the Signature error code message

### 2019-03-11 Version 1.2.2
* fix bug: fix user-agent set error when user use .net framework 4.6.1 with core version 1.2.0 to get response
* Add credential chains

### 2019-02-27 Version: 1.2.0
* fix bug: fix a dictionary handle error that will cause cpu 100% #43
* Add User-Agent to the http/https protocol
* Add support for http debug 
* Update the SignatureDoesNotMatch error Message

### 2018-03-15 Version: 1.1.12
* compatible .net core

### 2018-03-12 Version: 1.1.11
* Update internal endpoints

### 2018-03-01 Version: 1.1.10
* Support dotnet standard 2.0

### 2018-02-01 Version: 1.1.9
* Support The STS token access.
* Support no AK access on ECS.

### 2018-01-16 Version: 1.1.8
* fix bug: SSL validation is disable for the whole program

### 2017-11-01 Version: 1.1.7
* 支持common调用

### 2017-09-25 Version: 1.1.6
* 修改post方式不能传输body的bug
* 修改ROA方式调用的相关bug

### 2017-09-06 Version: 1.1.6
* 修改IoT套件美西和新加坡节点的endpoint

### 2017-08-05 Version: 1.1.5
* 支持Api定义showJsonItemName=false
* 消除编译警告

### 2017-07-27 Version: 1.1.4
* 支持自动寻址，自动寻址endpoint缓存失效时间为1小时
* 手动调用AddEndpoint方法添加的endpoint优先级高于自动寻址

### 2017-07-25 Version: 1.1.3
* 修改IoT套件在华东2个Region上的endpoint。
