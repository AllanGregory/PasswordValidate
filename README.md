# PasswordValidate

## Como executar o projeto?

- Baixar o código fonte para a máquina local
- Utilizar o VS Code ou o Visual Studio 2019 (v.16.8+)
  - No VSCode executar o comando:
    ```
    dotnet run
    ```
  - No Visual Studio apertar F5 ou clicar em Run do IIS Express

## Para testar o projeto em execução

> Obs.: Por premissa, ter o .Net 5 instalado na máquina.

Utilize uma ferramenta que faça requisições para a API, por exemplo, o Postman.

A porta SSL que abrirá a aplicação será: 44382.

A requisição GET poderá ser feita, por exemplo, no endereço:
> https://localhost:44382/api/PasswordValidate

A requisição recebe um parâmetro JSON, no seguinte formato:
```
{
    "InputPassword" : "AbTp9!fok"
}
```

O nome do parâmetro deverá ser "InputPassword".

O retorno dessa requisição será **true** ou **false**.

## Solução

A solução foi pensada de forma que apenas 2 camadas seriam necessárias na arquitetura.

A camada Controller para recepção das requisições e a camada Business para tratar das validações, tendo em vista que uma camada de Services não seria utilizada, pois não há conexão com serviços externos.

### Validações

As validações funcionam com booleanos, onde retorno false para o primeiro indício de que a senha digitada foge das regras estipuladas, sem necessidade de correr todos os caracteres que recebo na requisição.

Cada validação possui sua classe e as configurações de tamanho da senha e caracteres especiais foram colocados no arquivo appsettings.json, permitindo que isso possa ser alterado a qualquer momento e não fique hardcoded dentro da aplicação.

### Exceções

As exceções estão sendo jogadas para as camadas superiores, onde na camada Controller termina sua tratativa apenas com um Console.WriteLine da Message + StackTrace.

A exceção é devolvida no Postman com o StatusCode e com a mensagem necessária. Aqui ela não foi tratada para voltar um JSON formatado, pois eu assumi que o retorno da API deveria ser apenas um **true** ou **false**. Estudei a implementação do Error Handling para colocá-lo como uma nova rota de Controller e tratá-lo, porém, preferi não retornar o **true** ou **false** dentro de um objeto JSON, optei por retornar apenas o resultado **true** ou **false**.
