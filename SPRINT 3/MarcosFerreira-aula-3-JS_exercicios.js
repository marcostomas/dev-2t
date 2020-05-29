/*
Declare uma variável `pessoa`, que receba suas informações pessoais.
As propriedades e tipos de valores para cada propriedade desse objeto devem ser:
- `nome` - String
- `sobrenome` - String
- `genero` - String
- `idade` - Number
- `altura` - Number
- `peso` - Number
- `andando` - Boolean - recebe "falso" por padrão
- `caminhouQuantosMetros` - Number - recebe "zero" por padrão
*/

var pessoa = {
    nome : 'Marcos',
    sobrenome: 'Ferreira',
    genero: 'Masculino',
    idade: 17,
    altura: 1.73,
    peso: 72,
    andando: false,
    caminhouQuantosMetros: 0
};



/*
Adicione um método ao objeto `pessoa` chamado `fazerAniversario`. O método deve
alterar o valor da propriedade `idade` dessa pessoa, somando `1` a cada vez que
for chamado.
*/

function fazerAniversario(){
    pessoa.idade = pessoa.idade + 1
};


/*
Adicione um método ao objeto `pessoa` chamado `andar`, que terá as seguintes
características:
- Esse método deve receber por parâmetro um valor que representará a quantidade
de metros caminhados;
- Ele deve alterar o valor da propriedade `caminhouQuantosMetros`, somando ao
valor dessa propriedade a quantidade passada por parâmetro;
- Ele deverá modificar o valor da propriedade `andando` para o valor
booleano que representa "verdadeiro";
*/

function andar(caminhouQuantosMetros, qtdM){
    pessoa.caminhouQuantosMetros = caminhouQuantosMetros + qtdM
    pessoa.andando = true
};

var qtdM = 500; 

/*
Adicione um método ao objeto `pessoa` chamado `parar`, que irá modificar o valor
da propriedade `andando` para o valor booleano que representa "falso".
*/

function parar(){
    pessoa.andando = false
};

/*
Crie um método chamado `nomeCompleto`, que retorne a frase:
- "Olá! Meu nome é [NOME] [SOBRENOME]!"
*/

function nomeCompleto(){
    return "Olá! Meu nome é " + pessoa.nome + " " + pessoa.sobrenome
};


/*
Crie um método chamado `mostrarIdade`, que retorne a frase:
- "Olá, eu tenho [IDADE] anos!"
*/

function mostrarIdade(){
    return "Olá, eu tenho " + pessoa.idade + " anos"
};

/*
Crie um método chamado `mostrarPeso`, que retorne a frase:
- "Eu peso [PESO]Kg."
*/

function mostrarPeso(){
    return "Eu peso " + pessoa.peso + "Kg"
};

/*
Crie um método chamado `mostrarAltura` que retorne a frase:
- "Minha altura é [ALTURA]m."
*/

function mostrarAltura(){
    return "Minha altura é " + pessoa.altura + "m"
};


/*
Agora vamos trabalhar um pouco com o objeto criado:
Qual o nome completo da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(nomeCompleto()) //Olá! Meu nome é Marcos Ferreira



/*
Qual a idade da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(mostrarIdade()) //Olá, eu tenho 17 anos



/*
Qual o peso da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(mostrarPeso()) //Eu peso 72Kg


/*
Qual a altura da pessoa? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

console.log(mostrarAltura()) //Minha altura é 1.73m



/*
Faça a `pessoa` fazer 3 aniversários.
*/

for (i = 0; i < 3; i++) {
    console.log(fazerAniversario());
}


/*
Quantos anos a `pessoa` tem agora? (Use a instrução para responder e
comentários inline ao lado da instrução para mostrar qual foi a resposta
retornada)
*/

console.log(mostrarIdade()) //Olá, eu tenho 20 anos



/*
Agora, faça a `pessoa` caminhar alguns metros, invocando o método `andar` 3x,
com as distâncias diferentes passadas por parâmetro.
*/

for (i = 0; i < 3; i++) {
    console.log(andar(pessoa.caminhouQuantosMetros,qtdM));
}

/*
A pessoa ainda está andando? (Use a instrução para responder e comentários
inline ao lado da instrução para mostrar qual foi a resposta retornada)
*/

if (pessoa.andando)
{
    console.log("A pessoa está andando")    //A pessoa está andando
}else{
    console.log("A pessoa não está andando")
}



/*
Se a pessoa ainda está andando, faça-a parar.
*/

if(pessoa.andando)
{
    console.log(parar())
}


/*
E agora: a pessoa ainda está andando? (Use uma instrução para responder e
comentários inline ao lado da instrução para mostrar a resposta retornada)
*/

if (pessoa.andando)
{
    console.log("A pessoa está andando")
}else{
    console.log("A pessoa não está andando")    //A pessoa não está andando
}



/*
Quantos metros a pessoa andou? (Use uma instrução para responder e comentários
inline ao lado da instrução para mostrar a resposta retornada)
*/

console.log(pessoa.caminhouQuantosMetros); //1500



/*
Agora, vamos deixar a brincadeira um pouco mais divertida! :D
Crie um método para o objeto `pessoa` chamado `apresentacao`. Esse método deve
retornar a string:
- "Olá, eu sou o [NOME COMPLETO], tenho [IDADE] anos, [ALTURA], meu peso é [PESO] e, só hoje, eu já caminhei [CAMINHOU QUANTOS METROS] metros!"

Só que, antes de retornar a string, você vai fazer algumas validações:
- Se o `genero` de `pessoa` for "Feminino", a frase acima, no início da
apresentação, onde diz "eu sou o", deve mostrar "a" no lugar do "o";
- Se a idade for `1`, a frase acima, na parte que fala da idade, vai mostrar a
palavra "ano" ao invés de "anos", pois é singular;
- Se a quantidade de metros caminhados for igual a `1`, então a palavra que
deve conter no retorno da frase acima é "metro" no lugar de "metros".
- Para cada validação, você irá declarar uma variável localmente (dentro do
método), que será concatenada com a frase de retorno, mostrando a resposta
correta, de acordo com os dados inseridos no objeto.
*/

function apresentacao(){

    if(pessoa.genero === "Feminino"){
        genero = "a";
    }else{
        genero = "o";
    }

    if(pessoa.idade === 1){
        anos  = "ano";
    }else{
        anos = "anos";
    }

    if(pessoa.caminhouQuantosMetros === 1){
        metros = "metro";
    }else{
        metros = "metros";
    }

    return "Olá, eu sou " + genero + " " + pessoa.nome + " " + pessoa.sobrenome + ", tenho " + pessoa.idade + " " +
            anos + ", tenho " + pessoa.altura + " m, meu peso é " + pessoa.peso + "kg e, só hoje, eu já caminhei " + 
            pessoa.caminhouQuantosMetros + " " + metros;
}



/* Agora, apresente-se. */

console.log(apresentacao());