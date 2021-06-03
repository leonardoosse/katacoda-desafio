# API Segmento api-segmento

API para consultar e parametrizar a taxa do segmento do cliente.

A API foi desenvolvida em .Net Core 3.1.

1. Acessar o diretório da API .

`cd ~/katacoda-desafio/api-segmento`{{execute}}

2. Gerar a imagem 

`docker build -t image-api-segmento:1.0.0 -f Dockerfile . `{{execute}}

3. Criar o contêiner a partir da imagem gerada. 

`docker run -p 8080:5001 --name api-segmento -d image-api-segmento:1.0.0`{{execute}}

4. Acessar o endereço https://[[HOST_SUBDOMAIN]]-8080-[[KATACODA_HOST]].environments.katacoda.com/segmentos para validar API.



