create table sistemas_vendas(
produtos    varchar2(30),
clientes    varchar2(50),
vendas      number(10),
pagamentos  number(10,2)
);

insert into sistemas_vendas (produtos,clientes,vendas,pagamentos)
values ('fone airpods','Jose Bezerra',512,89562.14);

select * from sistemas_vendas;

insert into sistemas_vendas (produtos,clientes,vendas,pagamentos)
values ('tv samsung smart 4k','Daniela',521,95874.58);

insert into sistemas_vendas (produtos,clientes,vendas,pagamentos)
values ('fone airpods','Jose Bezerra',512,89562.14);

insert into sistemas_vendas (produtos,clientes,vendas,pagamentos)
values ('munitor 100hz','Guilerme',412,32544.52);

insert into sistemas_vendas (produtos,clientes,vendas,pagamentos)
values ('RTX 5070','Joao pedro',962,102521.58);

CREATE VIEW SOMA_VENDAS AS
SELECT SUM(VENDAS) AS TOTAL_VENDIDO
FROM SISTEMAS_VENDAS;

SELECT*FROM SOMA_VENDAS;


-----------------------------------------------------------------------------------------------------------------------------------------------------------------




create table jogos_online(
ID_JOGADOR NUMBER PRIMARY KEY,
NOME VARCHAR2(20),
NICKNAME VARCHAR2(30),
NIVEL NUMBER(10),
XP VARCHAR2(10)
);


CREATE TABLE PARTIDAS(
ID_PARTIDA NUMBER PRIMARY KEY,
ID_JOGADOR NUMBER ,
DATA_PARTIDA DATE,
RESULTADO VARCHAR2(10), 
PONTOS NUMBER,
FOREIGN KEY (ID_JOGADOR)REFERENCES JOGOS_ONLINE (ID_JOGADOR)
);

CREATE TABLE CONQUISTA(
ID_CONQUISTA NUMBER PRIMARY KEY,
NOME VARCHAR2(50),
DESCRICAO VARCHAR2(100)
);

INSERT INTO jogos_online VALUES(1,'Joao','slayerBR',5,1500);
INSERT INTO jogos_online VALUES(2,'gabriel','shadowboy',3,700);
INSERT INTO jogos_online VALUES(3,'carlos','xxfuriaxx',7,2500);

INSERT INTO PARTIDAS VALUES (101, 1, SYSDATE - 3, 'Vitória', 300);
INSERT INTO PARTIDAS VALUES (102, 2, sysdate - 1, 'Derrota',0);
INSERT INTO PARTIDAS VALUES (103, 3, sysdate - 2, 'Vitoria', 400);

INSERT INTO CONQUISTA VALUES (1, 'Matador de Dragões', 'Derrote 10 dragões');
INSERT INTO CONQUISTA VALUES (2, 'iniciante', 'jogeu sua primeira partida');
INSERT INTO CONQUISTA VALUES (3, 'invencivel', 'ganhe 5 partidas seguidas');

SELECT * FROM jogos_online;
 SELECT * FROM PARTIDAS ;
