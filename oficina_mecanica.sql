create table oficina_Mecanica (
id_carros  number primary key,
nome varchar2(30),
carro varchar2(30),
cliente varchar2(20),
servico  varchar2(50) 
);
select * from oficina_mecanica;

insert into oficina_mecanica(id_carros,nome,carro,cliente,servico)
values (1,'joao pedro','gt3 rs','caio fernandes','adicionar molas esportivas');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (2, 'maria silva', 'civic si', 'ana costa', 'troca de óleo e filtro');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (3, 'joão lucas', 'gol gti', 'bruno rocha', 'revisão geral');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (4, 'luan santos', 'uno turbo', 'carlos lima', 'instalar escapamento esportivo');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (5, 'juliana pires', 'fusca 76', 'denise sousa', 'pintura completa');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (6, 'rafael dias', 'corolla xei', 'fernando alves', 'alinhamento e balanceamento');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (7, 'paulo henrique', 'hb20 turbo', 'gabriel oliveira', 'substituir pastilhas de freio');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (8, 'carla lima', 'ka sedan', 'hugo santos', 'reparo na embreagem');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (9, 'lucas mota', 'vectra elite', 'isabela martins', 'verificação elétrica');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (10, 'aline souza', 'audi a3', 'joão pedro', 'instalação de som automotivo');

INSERT INTO OFICINA_MECANICA (id_carros, nome, carro, cliente, servico)
VALUES (11, 'thiago costa', 's10 high country', 'karen vieira', 'troca de suspensão traseira');

select * from oficina_mecanica;



select * from oficina_mecanica where servico like '%óleo%';


update  oficina_mecanica 
set servico = 'revisao de freio'
where id_carros = 2;

select * from oficina_mecanica ;

delete from oficina_mecanica
where id_carros = 5;

select * from oficina_mecanica ;

alter table oficina_mecanica
add trabalho_feito varchar2(30);

update oficina_mecanica
set trabalho_feito = 'já esta pronto' 
where id_carros = 1 ;

update oficina_mecanica
set trabalho_feito = 'pastilha precisa trocar ' 
where id_carros = 2 ;

update oficina_mecanica
set trabalho_feito = 'tudo certo' 
where id_carros = 3;

update oficina_mecanica
set trabalho_feito = 'escapameto nao chegou a inda' 
where id_carros = 4;

update oficina_mecanica
set trabalho_feito = 'so alinhaemnto ' 
where id_carros = 6;

update oficina_mecanica
set trabalho_feito = 'feito' 
where id_carros = 7 ;


update oficina_mecanica
set trabalho_feito = 'peça quebrada esprando chegar' 
where id_carros = 8 ;

update oficina_mecanica
set trabalho_feito = 'mudar modulo de abastecimento' 
where id_carros = 9 ;

update oficina_mecanica
set trabalho_feito = 'feito' 
where id_carros = 10 ;


update oficina_mecanica
set trabalho_feito = 'esrando chegar' 
where id_carros = 11;

select * from oficina_mecanica;

alter table oficina_mecanica
add pago number(10);

ALTER TABLE oficina_mecanica
MODIFY pago varchar2(3);



update oficina_mecanica
set pago = 'S' 
where id_carros = 1;


update oficina_mecanica
set pago = 'S' 
where id_carros = 2;

update oficina_mecanica
set pago = 'S' 
where id_carros = 3;

update oficina_mecanica
set pago = 'S' 
where id_carros = 4;

update oficina_mecanica
set pago = 'S' 
where id_carros = 6;

update oficina_mecanica
set pago = 'S' 
where id_carros = 7;

update oficina_mecanica
set pago = 'S' 
where id_carros = 8;

update oficina_mecanica
set pago = 'N' 
where id_carros = 9;

update oficina_mecanica
set pago = 'S' 
where id_carros = 10;


update oficina_mecanica
set pago = 'N' 
where id_carros = 11;

select * from oficina_mecanica;