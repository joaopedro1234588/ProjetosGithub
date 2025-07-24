create table marca_chocolate(
marca varchar2(20),
lote number(9) primary key,
validade date,
sabor varchar2(10)
);

(
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor)
VALUES ('Nestle', 10001, TO_DATE('30/12/2025', 'DD/MM/YYYY'), 'Ao leite');

INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Garoto', 1002, TO_DATE('15/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Lacta', 1003, TO_DATE('10/02/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Kinder', 1004, TO_DATE('25/03/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('CacauShow', 1005, TO_DATE('05/04/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Hersheys', 1006, TO_DATE('20/04/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Nestle', 1007, TO_DATE('01/05/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Garoto', 1008, TO_DATE('15/05/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Lacta', 1009, TO_DATE('10/06/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Kinder', 1010, TO_DATE('25/06/2026','DD/MM/YYYY'), 'Ao leite');



INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Nestle', 1011, TO_DATE('01/01/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Garoto', 1012, TO_DATE('02/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Lacta', 1013, TO_DATE('03/01/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Kinder', 1014, TO_DATE('04/01/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('CacauShow', 1015, TO_DATE('05/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Hersheys', 1016, TO_DATE('06/01/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Nestle', 1017, TO_DATE('07/01/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Garoto', 1018, TO_DATE('08/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Lacta', 1019, TO_DATE('09/01/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Kinder', 1020, TO_DATE('10/01/2026','DD/MM/YYYY'), 'Ao leite');

INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('CacauShow', 1021, TO_DATE('11/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Hersheys', 1022, TO_DATE('12/01/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Nestle', 1023, TO_DATE('13/01/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Garoto', 1024, TO_DATE('14/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Lacta', 1025, TO_DATE('15/01/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Kinder', 1026, TO_DATE('16/01/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('CacauShow', 1027, TO_DATE('17/01/2026','DD/MM/YYYY'), 'Amargo');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Hersheys', 1028, TO_DATE('18/01/2026','DD/MM/YYYY'), 'Branco');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Nestle', 1029, TO_DATE('19/01/2026','DD/MM/YYYY'), 'Ao leite');
INSERT INTO MARCA_CHOCOLATE (marca, lote, validade, sabor) VALUES ('Garoto', 1030, TO_DATE('20/01/2026','DD/MM/YYYY'), 'Amargo');
-- ...)

select *from marca_chocolate;

update marca_chocolate
set sabor = 'cookies'
where lote = 1022;

alter table marca_chocolate

add alergiscos varchar2(80);

)

select * from marca_chocolate;

alter table marca_chocolate
add alergicos varchar2(80);

update marca_chocolate
set alergicos = 'contem latose'
where lote =10001;


update marca_chocolate
set alergicos = 'contem glutem'
where lote =1002;


update marca_chocolate
set alergicos = 'castanha do pará'
where lote =1003;

update marca_chocolate
set alergicos = 'castanho de caju'
where lote =1004;

(
UPDATE MARCA_CHOCOLATE SET alergicos = 'castanha de caju'     WHERE lote = 10001;
UPDATE MARCA_CHOCOLATE SET alergicos = 'glúten'               WHERE lote = 1002;
UPDATE MARCA_CHOCOLATE SET alergicos = 'leite'                WHERE lote = 1003;
UPDATE MARCA_CHOCOLATE SET alergicos = 'soja'                 WHERE lote = 1004;
UPDATE MARCA_CHOCOLATE SET alergicos = 'amendoim'             WHERE lote = 1005;
UPDATE MARCA_CHOCOLATE SET alergicos = 'avelã'                WHERE lote = 1006;
UPDATE MARCA_CHOCOLATE SET alergicos = 'lactose'              WHERE lote = 1007;
UPDATE MARCA_CHOCOLATE SET alergicos = 'ovo'                  WHERE lote = 1008;
UPDATE MARCA_CHOCOLATE SET alergicos = 'glúten e leite'       WHERE lote = 1009;
UPDATE MARCA_CHOCOLATE SET alergicos = 'amêndoas'             WHERE lote = 1010;
UPDATE MARCA_CHOCOLATE SET alergicos = 'castanha-do-pará'     WHERE lote = 1011;
UPDATE MARCA_CHOCOLATE SET alergicos = 'corante artificial'   WHERE lote = 1012;
UPDATE MARCA_CHOCOLATE SET alergicos = 'aromatizante sintético' WHERE lote = 1013;
UPDATE MARCA_CHOCOLATE SET alergicos = 'trigo'                WHERE lote = 1014;
UPDATE MARCA_CHOCOLATE SET alergicos = 'leite e soja'         WHERE lote = 1015;
UPDATE MARCA_CHOCOLATE SET alergicos = 'cevada'               WHERE lote = 1016;
UPDATE MARCA_CHOCOLATE SET alergicos = 'nozes'                WHERE lote = 1017;
UPDATE MARCA_CHOCOLATE SET alergicos = 'glúten e ovo'         WHERE lote = 1018;
UPDATE MARCA_CHOCOLATE SET alergicos = 'soja e amendoim'      WHERE lote = 1019;
UPDATE MARCA_CHOCOLATE SET alergicos = 'nenhum'               WHERE lote = 1020;
UPDATE MARCA_CHOCOLATE SET alergicos = 'glúten'               WHERE lote = 1021;
UPDATE MARCA_CHOCOLATE SET alergicos = 'leite e castanhas'    WHERE lote = 1022;
UPDATE MARCA_CHOCOLATE SET alergicos = 'soja'                 WHERE lote = 1023;
UPDATE MARCA_CHOCOLATE SET alergicos = 'avelã'                WHERE lote = 1024;
UPDATE MARCA_CHOCOLATE SET alergicos = 'corante artificial'   WHERE lote = 1025;
UPDATE MARCA_CHOCOLATE SET alergicos = 'amêndoas e leite'     WHERE lote = 1026;
UPDATE MARCA_CHOCOLATE SET alergicos = 'amendoim e soja'      WHERE lote = 1027;
UPDATE MARCA_CHOCOLATE SET alergicos = 'lactose'              WHERE lote = 1028;
UPDATE MARCA_CHOCOLATE SET alergicos = 'nenhum'               WHERE lote = 1029;
UPDATE MARCA_CHOCOLATE SET alergicos = 'trigo e leite'        WHERE lote = 1030;
)

select*from marca_chocolate;


alter table marca_chocolate
add peso  varchar2(6); 

UPDATE MARCA_CHOCOLATE SET peso = '25.9g'               WHERE lote = 10001;
UPDATE MARCA_CHOCOLATE SET peso = ' 41.5g'              WHERE lote = 1002;
UPDATE MARCA_CHOCOLATE SET peso = '78.5g'               WHERE lote = 1003;
UPDATE MARCA_CHOCOLATE SET peso = '63.2g'               WHERE lote = 1004;
UPDATE MARCA_CHOCOLATE SET peso = '56.6g'               WHERE lote = 1005;
UPDATE MARCA_CHOCOLATE SET peso = '54.5g'               WHERE lote = 1006;
UPDATE MARCA_CHOCOLATE SET peso = '94.7g'               WHERE lote = 1007;
UPDATE MARCA_CHOCOLATE SET peso = '26.3g'               WHERE lote = 1008;
UPDATE MARCA_CHOCOLATE SET peso = '46.9g'               WHERE lote = 1009;
UPDATE MARCA_CHOCOLATE SET peso = '56.6g'               WHERE lote = 1010;
UPDATE MARCA_CHOCOLATE SET peso = '65.5g'               WHERE lote = 1011;
UPDATE MARCA_CHOCOLATE SET peso = ' 65.5g'              WHERE lote = 1012;
UPDATE MARCA_CHOCOLATE SET peso = '89.2g '              WHERE lote = 1013;
UPDATE MARCA_CHOCOLATE SET peso = '64.3g'               WHERE lote = 1014;
UPDATE MARCA_CHOCOLATE SET peso = ' 65.4g '             WHERE lote = 1015;
UPDATE MARCA_CHOCOLATE SET peso = '54.5g'               WHERE lote = 1016;
UPDATE MARCA_CHOCOLATE SET peso = '65.4g'               WHERE lote = 1017;
UPDATE MARCA_CHOCOLATE SET peso = '82.4g'               WHERE lote = 1018;
UPDATE MARCA_CHOCOLATE SET peso = '45.1g'               WHERE lote = 1019;
UPDATE MARCA_CHOCOLATE SET peso = '84.8g'               WHERE lote = 1020;
UPDATE MARCA_CHOCOLATE SET peso = '54.8'                WHERE lote = 1021;
UPDATE MARCA_CHOCOLATE SET peso = ' 51.2g'              WHERE lote = 1022;
UPDATE MARCA_CHOCOLATE SET peso= '47.7g'                WHERE lote = 1023;
UPDATE MARCA_CHOCOLATE SET peso = '96.4g'               WHERE lote = 1024;
UPDATE MARCA_CHOCOLATE SET peso = '78.4g '              WHERE lote = 1025;
UPDATE MARCA_CHOCOLATE SET peso = '45.2g'               WHERE lote = 1026;
UPDATE MARCA_CHOCOLATE SET peso = '25.2g'               WHERE lote = 1027;
UPDATE MARCA_CHOCOLATE SET peso = '54.5g'               WHERE lote = 1028;
UPDATE MARCA_CHOCOLATE SET peso = '58.6g'               WHERE lote = 1029;
UPDATE MARCA_CHOCOLATE SET peso = '54.8g'               WHERE lote = 1030;
select * from marca_chocolate;

ALTER TABLE MARCA_CHOCOLATE MODIFY PESO VARCHAR2(20);
  

ALTER TABLE MARCA_CHOCOLATE DROP COLUMN PESO;


ALTER TABLE MARCA_CHOCOLATE ADD DENCIDADE NUMBER(6,3);


SELECT * FROM  MARCA_CHOCOLATE;

ALTER TABLE  MARCA_CHOCOLATE ADD DENCIDADE NUMBER(6,3) ;

UPDATE MARCA_CHOCOLATE SET DENCIDADE = 7.524        WHERE lote = 10001;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 9.548        WHERE lote = 1002;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.412        WHERE lote = 1003;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 4.251        WHERE lote = 1004;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 8.524        WHERE lote = 1005;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.426        WHERE lote = 1006;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 7.459        WHERE lote = 1007;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 4.581        WHERE lote = 1008;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 1.745        WHERE lote = 1009;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 9.365        WHERE lote = 1010;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 3.569        WHERE lote = 1011;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 7.962        WHERE lote = 1012;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 4.125        WHERE lote = 1013;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 6.587        WHERE lote = 1014;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.874        WHERE lote = 1015;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 9.541        WHERE lote = 1016;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 6.984        WHERE lote = 1017;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 4.125        WHERE lote = 1018;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 3.254        WHERE lote = 1019;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 3.514        WHERE lote = 1020;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 8.524        WHERE lote = 1021;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 4.521        WHERE lote = 1022;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 3.547        WHERE lote = 1023;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 3.254        WHERE lote = 1024;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 6.854        WHERE lote = 1025;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.478        WHERE lote = 1026;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.741        WHERE lote = 1027;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.474        WHERE lote = 1028;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 5.747        WHERE lote = 1029;
UPDATE MARCA_CHOCOLATE SET DENCIDADE = 9.578        WHERE lote = 1030;

select * from MARCA_CHOCOLATE ;

ALTER TABLE  MARCA_CHOCOLATE ADD RESULTADO_DAS_3 NUMBER(6,3) ;
 
SELECT* FROM MARCA_CHOCOLATE;



