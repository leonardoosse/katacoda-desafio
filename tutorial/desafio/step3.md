# API Cotação api-cotacao

API para a realização do Cálculo da Cotação da Moeda.

A API foi desenvolvida em .Net Core 3.1.

1. Acessar o diretório da API .

`cd ~/desafio-temp/desafio-itau/api-cotacao`{{execute}}

2. Gerar a imagem 

`docker build -t image-api-cotacao:1.0.0 -f Dockerfile . `{{execute}}

3. Criar o contêiner a partir da imagem gerada. 

`docker run -p 8081:5002 --name api-cotacao -d image-api-cotacao:1.0.0`{{execute}}

4. Acessar o endereço http://localhost:8081/conversao para verificar se a API está em execução.
