Produto produto = new Produto("vinho", 68.79, 10);

produto.addunidadeestoque(5);
produto.retirarunidadeestoque(2);

double valortotal = produto.calcularvalortotalestoque();

