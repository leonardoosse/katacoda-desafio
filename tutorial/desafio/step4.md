# Finalizando

Após encerrar a validação, vamos limpar o ambiente

## Parando o Banco de Dados

Após realizar os testes no Banco de Dados, executar os passos abaixo:

1. Excluir o diretório das aplicações

`sudo rm -r ~/desafio-itau`{{execute}}

2. Parar o contêiner  

`docker stop api-cotacao`{{execute}}

`docker stop front-desafio`{{execute}}

`docker stop api-segmento`{{execute}}

3. Remover o contêiner  

`docker rm api-cotacao`{{execute}}

`docker rm api-segmento`{{execute}}

`docker rm front-desafio`{{execute}}

`docker container prune -f`{{execute}}

4. Remover a imagem  

`docker rmi image-api-cotacao:1.0.0 -f`{{execute}}

`docker rmi image-api-segmento:1.0.0 -f`{{execute}}

`docker rmi image-front-desafio:1.0.0 -f`{{execute}}

`docker image prune -f`{{execute}}

