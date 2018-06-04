#!/bin/bash

wget 'https://dev.mysql.com/get/Downloads/MySQL-5.7/mysql-5.7.18-winx64.zip'
unzip mysql-5.7.18-winx64.zip
./mysql-5.7.18-winx64/bin/mysqld.exe --initialize-insecure --console
./mysql-5.7.18-winx64/bin/mysqld.exe --console &
sleep 30
dotnet run
