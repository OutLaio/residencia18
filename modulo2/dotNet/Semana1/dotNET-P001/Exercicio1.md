
> _Para verificar se o .NET SDK está corretamente instalado no sistema, é possível usar alguns comandos no terminal._
> _Abaixo estão exemplos de comandos que podem ser úteis para verificar, remover e atualizar o .NET SDK:_


# Verificar a versão do .NET SDK instalado:

- Este comando exibirá a versão atual do .NET SDK instalado no sistema.
```
dotnet --version
```


# Listar todas as versões do .NET SDK instaladas:
- Este comando mostrará uma lista de todas as versões do .NET SDK instaladas no sistema.
```
dotnet --list-sdks
```

# Listar todas as versões do .NET runtimes instaladas:
- Este comando mostrará uma lista de todas as versões do .NET runtime instaladas no sistema.
```
dotnet --list-runtimes
```

# Remover uma versão específica do .NET SDK:

- Substituindo _`<version>`_ pela versão específica que se deseja desinstalar.
```
dotnet --uninstall-sdk <version>
```

# Remover uma versão específica do .NET runtime:

- Substituindo _`<version>`_ pela versão específica que se deseja desinstalar.
```
dotnet --uninstall-runtime <version>
```

# Atualizar para a versão mais recente do .NET SDK:

- Substituindo _`<version>`_ pela versão mais recente disponível. O comando dotnet --install-sdk instalará a versão especificada.
```
dotnet --version
dotnet --list-sdks
dotnet --install-sdk <version>
```