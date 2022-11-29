# MIPSA
Simple MIPS Assembler

Esse aplicativo foi desenvolvido para auxiliar as atividades da disciplina Lab. de Arquitetura de Sistemas Digitais, do curso de Engenharia Elétrica da Universidade Federal de Campina Grande - UFCG.

É um software assemblador que gera código de máquina para o processador MIPS desenvolvido por cada um dos alunos. Esses processadores têm 8 registradores de 8bits, 1kbyte de memória de instruções, 256bytes de memória de dados e uma ULA com 5 operações. Mais detalhes na seguinte playlist: https://youtube.com/playlist?list=PLKM6TRQ8YHKdxnB_G8raC3J1onhAeWJoA

As seguintes instruções são suportadas:
 * ADD $X, $Y, $Z
 * SUB $X, $Y, $Z
 * AND $X, $Y, $Z
 * OR $X, $Y, $Z
 * SLT $X, $Y, $Z
 * LW $X, i($Y)
 * SW $X, i($Y)
 * BEQ $X, $Y, i
 * ADDi $X, $Y, i
 * ANDi $X, $Y, i
 * ORi $X, $Y, i
 * SLTi $X, $Y, i
 * J i
 * XOR $X, $Y, shamt
 * SLL %X, $Y, shamt
 * SRL %X, $Y, shamt
 * SRA %X, $Y, shamt
 * SLLv %X, $Y, $Z
 * SRLv %X, $Y, shamt
 * SRAv %X, $Y, shamt
 * JAL i
