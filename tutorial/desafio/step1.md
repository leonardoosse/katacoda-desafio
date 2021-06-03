# Preparação

1. Criar o diretório de pastas e baixar o projeto desafio-itau do Github.

`git clone https://github.com/leonardoosse/desafio-itau.git`{{execute}}

`git clone https://github.com/leonardoosse/katacoda-desafio.git`{{execute}}

# API Cotação api-cotacao

API para a realização do Cálculo da Cotação da Moeda.

A API foi desenvolvida em .Net Core 3.1.

1. Acessar o diretório da API .

`cd ~/desafio-itau/api-cotacao`{{execute}}

2. Gerar a imagem 

`docker build -t image-api-cotacao:1.0.0 -f Dockerfile . `{{execute}}

3. Criar o contêiner a partir da imagem gerada. 

`docker run -p 8081:5002 --name api-cotacao -d image-api-cotacao:1.0.0`{{execute}}

4. Acessar o endereço https://[[HOST_SUBDOMAIN]]-8081-[[KATACODA_HOST]].environments.katacoda.com/conversao para verificar se a API está em execução.

