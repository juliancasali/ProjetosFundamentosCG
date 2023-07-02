# Tarefa Grau B - LEITOR/VISUALIZADOR DE CENAS 3D COM OPENGL MODERNA

1. Ler mais de um OBJ
a. já triangularizado, com normais e coordenadas de texturas
b. cada objeto ou grupo1 (submesh) possui seu índice de textura e suas
propriedades do material (ka, ks e kd) - que devem ser usados no shader de
iluminação
2. Ter pelo menos 1 fonte de luz, iluminação de Phong
a. Acrescentar os coeficientes ka, ks e kd do arquivo de materiais (.mtl)
b. Preferencialmente, deixar todos os coeficientes de iluminação
parametrizáveis (intensidade das fontes de luz, coeficiente da especular)
3. Controle de câmera por teclado e/ou mouse, provendo navegabilidade para a cena.
4. Seleção dos objetos via teclado e/ou mouse, permitindo a aplicação de operações
geométricas (rotação, translação e escala uniforme)
1 Durante a atividade vivencial de carregamento de malhas faremos um leitor simples, que considera apenas uma malha/grupo por objeto.
Incentivamos os estudantes a implementarem o leitor considerando mais de um grupo, porém não é um requisito obrigatório.
