Para este teste, criei uma solution com os seguintes projetos:
-WebAPI: Utilizando o .Net 8
-XUnit: Para realizar os testes unitários 

Neste teste, utilizei conceitos como injeção de dependência, segregação de interface e a utilização do padrão de projeto Template Method, onde existe uma classe base (RateCalculator) e 2 classes que herdam seu comportamento, e sobrescrevem para cada uma de suas especificidades (DetermineBitValue). 

O projeto está disponibilizado com o swagger, sendo possível testá-lo passando um array de bit como parâmetro, como o exemplo a seguir:
 "00100", "11110", "10110", "10111", "10101", "01111", "00111", "11100", "10000", "11001", "00010", "01010"
