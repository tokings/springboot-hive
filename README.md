#编译运行
在工程目录下，执行如下命令：
`mvn clean package -DskipTests`
编译成功后在target会找到phoenixAPI-0.0.1.jar
运行采用如下命令：
`nohup java -jar phoenixAPI-0.0.1.jar >/dev/null &` 
停止使用命令： `ps -ef|grep phoenixAPI-0.0.1.jar`找到pid kill

#端口与数据库参数配置
在src/main/resources目录下application.properties指定profiles：
test---测试环境
dev--开发环境
prod--生产环境
然后在application-{profile}.properties文件中配置
