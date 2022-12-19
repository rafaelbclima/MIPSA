# MIPSA
Simple MIPS Assembler

Esse aplicativo foi desenvolvido para auxiliar as atividades da disciplina Lab. de Arquitetura de Sistemas Digitais, do curso de Engenharia Elétrica da Universidade Federal de Campina Grande - UFCG.

É um software assemblador que gera código de máquina para o processador MIPS desenvolvido por cada um dos alunos em Verilog/Systemverilog. Esses processadores têm 8 registradores de 8bits, 1kbyte de memória de instruções, 256bytes de memória de dados e uma ULA com 6 operações. Mais detalhes na seguinte playlist: https://youtube.com/playlist?list=PLKM6TRQ8YHKdxnB_G8raC3J1onhAeWJoA


As seguintes instruções são suportadas:
|Instrução        |Descrição                 |
|-----------------|--------------------------|
|ADD $X, $Y, $Z   |$X = $Y + $Z     |
|SUB $X, $Y, $Z   |$X = $Y + ~$Z +1|
|AND $X, $Y, $Z   |$X = $Y & $Z|
|OR $X, $Y, $Z    |$X = $Y | $Z|
|NOR $X, $Y, $Z   |$X = ~($Y | $Z)|
|XOR $X, $Y, $Z   |$X = $Y ^ $Z|
|SLT $X, $Y, $Z   |$X = 1 se $Y < $Z e 0 c.c.|
|SLL $X, $Y, shamt|$X = $Y << shamt|
|SRL $X, $Y, shamt|$X = $Y >> shamt|
|SRA $X, $Y, shamt|$X = $Y >>> shamt|
|SLLv $X, $Y, $Z  |$X = $Y << $Z|
|SRLv $X, $Y, $Z  |$X = $Y >> $Z|
|SRAv $X, $Y, $Z  |$X = $Y >>> $Z|
|LW $X, i($Y)     |$X <= Cont. do end. ($Y+ i)|
|SW $X, i($Y)     |End. ($Y+ i) <= $X|
|BEQ $X, $Y, i    |Se $X == $Y, PC = PC + 1 + i|
|ADDi $X, $Y, i   |$X = $Y + i|
|ANDi $X, $Y, i   |$X = $Y & i|
|ORi $X, $Y, i    |$X = $Y | i|
|SLTi $X, $Y, i   |$X = 1 se $Y < i e 0 c.c.|
|J i              |PC = i|
|JAL i            |$7 = PC+1 e PC = i\n|
|NOP              |No operation|


![alt text](https://github.com/rafaelbclima/MIPSA/blob/main/temp.jpg)
