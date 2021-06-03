# Aplicação front-desafio

Aplicação que permite ao usuário realizar:
* cotação da compra de moeda estrangeira 
* parametrização e consulta da taxa cobrada por segmento.

A Aplicação foi desenvolvida em Angular versão 12.0.2.

1. Acessar o diretório da API .

`cd ~/desafio-itau/front-desafio`{{execute}}

2. Atualizar o endereço das APIs.

`src/app/cotacao/cotacao.component.ts`{{open}}

`src/app/parametrizacao/parametrizacao.component.ts`{{open}}

3. Gerar a imagem 

`docker build -t image-front-desafio:1.0.0 -f Dockerfile . `{{execute}}

4. Criar o contêiner a partir da imagem gerada. 

`docker run -p 5000:80 --name front-desafio -d image-front-desafio:1.0.0`{{execute}}

5. Acessar o endereço https://[[HOST_SUBDOMAIN]]-5000-[[KATACODA_HOST]].environments.katacoda.com/ para validar a aplicação.


