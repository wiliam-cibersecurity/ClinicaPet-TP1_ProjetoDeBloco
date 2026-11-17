# ClinicaPet - Sistema de Gestão Veterinária (TP1)
[![Status](https://img.shields.io/badge/STATUS-EM_DESENVOLVIMENTO-007EC6?style=for-the-badge)](#)
[![Etapa](https://img.shields.io/badge/RELEASE-TP1-808080?style=for-the-badge)](#)
[![Licença](https://img.shields.io/badge/LICENSE-EDUCATIONAL-73A808?style=for-the-badge)](#)

> Projeto desenvolvido para o Teste de Performance 1 (TP1) da disciplina de Engenharia de Software do Instituto Infnet. O foco desta entrega é a documentação de requisitos e a construção da base estrutural de um sistema de agendamento clínico.

## Estrutura do Repositório

O projeto está dividido em duas áreas principais:

- `/docs`: Contém a documentação técnica consolidada em PDF, abrangendo:
  - Levantamento de Requisitos Funcionais e Não Funcionais.
  - Definição das Regras de Negócio.
  - Especificação e Diagramas de Casos de Uso (UML).
  - Justificativa técnica de escopo.
  - Link de acesso para o vídeo de defesa do projeto.

- `/src`: Contém o código-fonte da aplicação C# inicial.

## Especificações Técnicas

- **Linguagem:** ![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=flat-square&logo=c-sharp&logoColor=white)
- **Framework:** ![.NET](https://img.shields.io/badge/.NET-5C2D91?style=flat-square&logo=.net&logoColor=white) 10.0 SDK
- **Interface:** Linha de Comando (CLI / Console Application)
- **Armazenamento:** Estruturas temporárias em memória (Arrays estáticos limitados a 100 posições).
- **Paradigma:** Estruturado (Restrição da etapa atual: não utilização de Orientação a Objetos).

## Escopo Atual (Iteração 1)

Nesta etapa inicial, o desenvolvimento foca na segurança do controle de fluxo e na navegação do usuário. As funcionalidades ativas no código incluem:

1. Controle de Acesso Lógico: Separação estrita de áreas e menus para os perfis de `Recepcionista` e `Veterinário`.
2. Navegação Segura: Implementação de menus via `switch-case` com tratamento nativo de exceções e entradas inválidas (bloco `default`), garantindo que a aplicação não sofra interrupções inesperadas (crashes).
3. Base de Armazenamento: Preparação de vetores paralelos em memória para simulação futura das entidades.
4. Mapeamento de Rotas: Rotas estruturadas para os casos de uso principais (Agendar Consulta, Cancelar Consulta e Registrar Atendimento) alinhadas com a modelagem UML.

## Próximas Etapas (Roadmap)

Conforme a evolução da disciplina, as seguintes implementações substituirão a estrutura provisória atual:

- Refatoração da arquitetura para o paradigma de Orientação a Objetos (POO).
- Integração com Banco de Dados para persistência real das informações.
- Implementação de lógicas avançadas de manipulação de tempo (DateTime) para validação de horários de plantão e regras de cancelamento (prazo de 12 horas).
- Integração de serviços para envio real de prontuários por e-mail e notificações móveis.

## Como Executar

Para rodar a aplicação localmente, certifique-se de ter o .NET 10 SDK instalado na máquina.

1. Clone este repositório.
2. Pelo terminal, navegue até a pasta do projeto: `cd src/CliniciaPetApp`
3. Execute o comando: `dotnet run`
4. (Opcional) O projeto também pode ser aberto e executado diretamente pressionando F5 no Visual Studio Community.

 Desenvolvido por Wiliam Jr. Da Maia - Engenharia de Software com Enfase em Cibersegurança (Instituto Infnet).
---

## 📄 Licença

Este projeto é disponibilizado exclusivamente para fins **educacionais e de demonstração**.

Desenvolvido por Wiliam Jr. Da Maia - Engenharia de Software com Enfase em Cibersegurança (Instituto Infnet).
