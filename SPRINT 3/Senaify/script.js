/* 
    Busca o elemento Html pelo atributo Id, 
    que se chama 'botao' 
*/
var botao = document.getElementById("botao");

var fundo = document.getElementById("fundo");

var fechar = document.getElementById("fechar");

// Realizar eventos
botao.onclick = function(){
    fundo.classList.add("visivel")
}

fechar.onclick = function(){
    fundo.classList.remove("visivel")
}