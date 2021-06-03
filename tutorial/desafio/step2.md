# Banco de Dados desafio_itau

Banco de dados SQLServer desenvolvido para armazenar as informação do segmento do cliente

Para teste da aplicação, podemos subir o banco de dados em um contêiner

1. Acessar o diretório da Banco de Dados.

`cd ~/desafio-temp/desafio-itau/bd-desafio`{{execute}}

2. Definir a Senha do Usuario SA

`DB_PASSWORD=LLX5Z@Uqhan8`{{execute}}

3. Criar o contêiner a partir da imagem do SQLServer. 

`docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=$DB_PASSWORD" -p 1433:1433 --name bd-desafio -h host-sql-server -d mcr.microsoft.com/mssql/server:2019-latest`{{execute}}  

4. Copiar os arquivos SQL para o contêiner

`docker cp .  bd-desafio:/tmp`{{execute}}

5. Criar banco de dados. 

`docker exec -it bd-desafio /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $DB_PASSWORD -i /tmp/DDL/create_database.sql`{{execute}}  

6. Criar tabela. 

`docker exec -it bd-desafio /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $DB_PASSWORD -i /tmp/DDL/create_table.sql`{{execute}}  

7. Inserir dados na tabela. 

`docker exec -it bd-desafio /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $DB_PASSWORD -i /tmp/DML/insert.sql`{{execute}}

8. Definir Senha do Usuário da Aplicação

`USER_PASSWORD=FRzs@58OiTF`{{execute}}

9. Criar o Usuário. 

`docker exec -it bd-desafio /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $DB_PASSWORD -Q "USE desafio_itau; CREATE LOGIN user_desafio WITH PASSWORD = '$USER_PASSWORD'; CREATE USER user_desafio FOR LOGIN user_desafio;"`{{execute}}  

10. Dar acesso da aplicação para o usuário 

`docker exec -it bd-desafio /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P $DB_PASSWORD -i /tmp/DCL/grant_user.sql`{{execute}}  

11. Validar. Consultar tabela segmento com usuário da aplicação

`docker exec -it bd-desafio /opt/mssql-tools/bin/sqlcmd -S localhost -U user_desafio -P $USER_PASSWORD -Q "use desafio_itau; SELECT * FROM segmentos"`{{execute}}  


