# Exercício Locadora de Carros

Aplique os conceitos de herança, composição, coesão, acoplamento e modificadores de acesso conforme necessários para resolver o problema. Não esqueça dos testes de unidade!

O gerente de uma locadora de veículos precisa obter um relatório diário contendo todos os veículos locados e uma estimativa dos valores que serão recebidos na data de devolução de cada veículo.
Cada tipo de veículo possui seu valor da diária, custo por quilômetro e alguns adicionais, conforme descritos abaixo:

Carro:
	Diária: R$ 50,00
	Quilometragem: R$ 0,50 por quilômetro
	Adicionais:
	GPS: R$ 25,00
	Cadeirinha: R$ 65,00

Motor home:
	Diária: R$ 300,00
	Quilometragem: R$ 0,65 por quilômetro
	Adicionais:
	GPS: R$ 35,00
	Cadeirinha: R$ 75,00
	Geladeira: R$ 250,00

O programa deve informar ao final do dia todos os aluguéis de veículos com as seguintes informações descritas para cada:
1) Tipo do Carro
2) Quantidade de diárias
3) Valor total das diárias
4) Estimativa de quilometragem em reais
5) Valores de todos os adicionais
6) Valor total do aluguel

Por exemplo, caso o cliente alugue um Motor Home do dia 21/10/2019 17:00 ao dia 23/10/2019 09:00, com adicionais de GPS e geladeira, estimativa de quilometragem de 850 quilômetros, os dados calculados deverão ser:
1) Tipo do Carro: Motor Home
2) Quantidade de diárias: 2
3) Valor total das diárias: R$ 600,00
4) Estimativa de quilometragem em reais: R$ 552,50
5) Valores de todos os adicionais: 
	GPS: R$ 35,00
	Geladeira: R$ 250,00
6) Valor total do aluguel:  R$ 1.437,50