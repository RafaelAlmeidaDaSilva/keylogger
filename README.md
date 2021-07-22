# keylogger
desenvolvido com interesse puramente acadêmico.

Objetivo desse sistema e capturar teclas em segundo plano. 

O sistema depende de um classe "hook" utilizada para capturar os eventos das teclas em segundo plano 

Segundo plano 
	Quando outros programas estão lendo e recebendo as teclas digitadas.
	
	
	O programa feito atualmente não esta utilizando todo o potencial orientado a objetos que deveria. Sem contar que não há uma estrutura de configuração adequados.
	
	
	Então o objetivo desse documento e esclarecer o funcionamento atual do sistema a fim de melhora-lo 
	
	Começando com a parte de orientação a objetos 
	
	O sistema depende de um arquitetura orientada a eventos onde:
		- Captura os eventos das teclas em segundo plano
		- Mapear a tecla acionada
		- Traduzir para uma maneira interpretativa.
	
	O programa também depende de uma caixa de texto utilizada para armazenar os textos de saída após o mapeamento.
	
	Pensando na arquitetura já podemos entender que cada tecla pode ser representada como um texto de entrada e outro de saída, onde poderia ser um lista de objetos digitados onde cada evento de tecla acionado poderia gerar 3 tipos de interpretação 
	
	Interpretações 
		- Não traduzidas 
		- Traduzidas 
		- Editadas 
		
		
		
         Pensando na arquitetura final orientada a objetos, teríamos que olhar para cada tecla como se fosse um objeto dentro do sistema. Simples. Teríamos que construir o objeto em tempo de execução onde após o mapeamento (tradução) seria possível identificar os tipos de interpretação e assim construir o objeto. 



Solução 

	Criar um objeto mapeamento, onde teria (Identificação, construção, adicionamento)
Dos objetos teclas que seriam (n/ traduzidos, traduzidos, editados) . Todos dentro do loop de evento da classe hook.![image](https://user-images.githubusercontent.com/20491286/126683550-f10b55d1-983b-4a16-b79d-147ca2621e4d.png)


###Legal

Este código não é de forma alguma afiliado, autorizado, mantido, patrocinado ou endossado pelo WhatsApp ou qualquer de suas afiliadas ou subsidiárias. Este é um software independente e não oficial. Use por sua conta e risco.

###License

A Licença MIT (MIT)

Copyright (c) 2018

A permissão é concedida, gratuitamente, a qualquer pessoa que obtenha uma cópia deste software e arquivos de documentação associados (o "Software"), para lidar com o Software sem restrição, incluindo, sem limitação, os direitos de usar, copiar, modificar, mesclar , publicar, distribuir, sublicenciar e / ou vender cópias do Software, e permitir que as pessoas a quem o Software é fornecido o façam, sujeito às seguintes condições:

O aviso de direitos autorais acima e este aviso de permissão devem ser incluídos em todas as cópias ou partes substanciais do Software.

O SOFTWARE É FORNECIDO "NO ESTADO EM QUE SE ENCONTRA", SEM QUALQUER TIPO DE GARANTIA, EXPRESSA OU IMPLÍCITA, INCLUINDO, SEM LIMITAÇÃO, AS GARANTIAS DE COMERCIALIZAÇÃO, ADEQUAÇÃO A UM DETERMINADO FIM E NÃO VIOLAÇÃO. EM NENHUMA HIPÓTESE OS AUTORES OU TITULARES DOS DIREITOS AUTORAIS SERÃO RESPONSÁVEIS POR QUALQUER RECLAMAÇÃO, DANOS OU OUTRA RESPONSABILIDADE, SEJA EM UMA AÇÃO DE CONTRATO, DELITO OU DE OUTRA FORMA, DECORRENTE DE, FORA DE OU EM CONEXÃO COM O SOFTWARE OU O USO OU OUTROS NEGÓCIOS NO PROGRAMAS.
