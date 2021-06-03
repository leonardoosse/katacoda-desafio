# API Segmento api-segmento

API para consultar e parametrizar a taxa do segmento do cliente.

A API foi desenvolvida em .Net Core 3.1.

1. Acessar o diretório da API .

`cd ~/desafio-temp/desafio-itau/api-segmento`{{execute}}

2. Informar a senha do usuário da aplicação definida na criação do banco de Dados

`USER_PASSWORD=FRzs@58OiTF`{{execute}}

3. Atualizar a connectionString para o IP local e a senha do usuário da aplicação.

`ipLocal=$(hostname -I | awk '{print $1}') && echo $ipLocal`{{execute}}

`conexao=$(echo "Server=$ipLocal,1433;Database=desafio_itau;Uid=user_desafio;Pwd=$USER_PASSWORD" | base64)`{{execute}}

`jq ".ConnectionStrings.ConexaoDesafioItau = \"$conexao\"" APISegmento/appsettings.json > tmp.$$.json && mv tmp.$$.json APISegmento/appsettings.json`{{execute}}

4. Gerar a imagem 

`docker build -t image-api-segmento:1.0.0 -f Dockerfile . `{{execute}}

5. Se desejar, subir a imagem em um repositório (DockerHub, ECR, ACR)

`docker push image-api-segmento:1.0.0`{{execute}}

6. Criar o contêiner a partir da imagem gerada. 

`docker run -p 8080:5001 --name api-segmento -d image-api-segmento:1.0.0`{{execute}}

7. Acessar o endereço http://localhost:8080/segmentos para validar a aplicação.



