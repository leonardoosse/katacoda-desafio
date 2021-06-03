# Aplicação front-desafio

Aplicação que permite ao usuário realizar:
* cotação da compra de moeda estrangeira 
* parametrização e consulta da taxa cobrada por segmento.

A Aplicação foi desenvolvida em Angular versão 12.0.2.

1. Acessar o diretório da API .

`cd ~/desafio-temp/desafio-itau/front-desafio`{{execute}}

2. Gerar a imagem 

`docker build -t image-front-desafio:1.0.0 -f Dockerfile . `{{execute}}

3. Se desejar, subir a imagem em um repositório (DockerHub, ECR, ACR)

`docker push image-front-desafio:1.0.0`{{execute}}

4. Criar o contêiner a partir da imagem gerada. 

`docker run -p 5000:80 --name front-desafio -d image-front-desafio:1.0.0`{{execute}}

5. Acessar o endereço http://localhost:5000/ para validar a aplicação.


