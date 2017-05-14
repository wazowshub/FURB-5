/*produtos por categoria que possuem mais de um produto
produtos por tipo
venda preços unitarios + valor total do usuario
relatório de usuarios clientes criados em um período
relatório de opções de frete de um determinado CEP
relatório de vendas nos ultimos 30 dias
todos produtos*/

--produtos por categoria que possuem mais de um produto
create or replace
view censo_categoria_v as
select b.descricao, 
	count(*) qtd, 
	max(a.valor) maior_valor
from Produto a, 
	categoria b
where a.id_categoria = b.id_categoria
group by b.descricao
having count(*) > 1;
/
	
--produtos por tipo
create or replace
view censo_tipo_prod_v as
select b.descricao, 
	count(*) qtd, 
	max(valor) maior_valor
from Produto a, 
	tipo_produto b
where a.id_Tproduto = b.id_Tproduto
group by b.descricao;
/

--venda preços unitarios + valor total da venda
create or replace
view rel_venda_v as
select c.nome, 
	a.valor_total, 
	b.valor valor_unitario,
	d.valor valor_frete
from venda a,
	venda_produto b,
	usuario c,
	frete d
where a.id_venda = b.id_venda
and a.id_usuario = c.id_usuario
and a.id_frete = d.id_frete;
/

select *
from rel_venda_v a
where a.id_venda = :id_venda
order by a.nome;

--relatório de usuarios clientes criados em um período
create or replace 
view cliente_v as
select a.nome, a.email, 
from usuario a
where a.id_Tusuario = 2; --cliente
/

select *
from cliente_v a
where a.dt_criacao between :dt_inicio and :dt_fim
order by a.nome;

--relatório de opções de frete de um determinado CEP
create or replace
view frete_transp_v as
select a.nome, b.cep_inicial, b.cep_final, b.valor
from transportadora a,
	frete b
where a.id_transportadora = b.id_transportadora
group by a.nome, 
		b.cep_inicial, 
		b.cep_final, 
		b.valor;
/

select *
from frete_transp_v a
where a.cep_inicial <= :cep
and a.cep_final >= :cep;

--relatório de vendas nos ultimos 30 dias
select b.nome, a.id_venda cod_venda,  a.valor_total
from venda a,
	usuario b
where a.id_usuario = b.id_usuario
and a.dt_realizacao between sysdate-30 and sysdate
union
select 'Valor Total', 0, sum(valor_total) total_geral
from venda a
where a.dt_realizacao between sysdate-30 and sysdate;

--todos produtos
select b.descricao ds_categoria, 
	c.descricao ds_tipo_produto,
	a.nome, 
	a.valor
from produto a,
	categoria b,
	tipo_produto c
where a.id_categoria = b.id_categoria
and a.id_Tproduto = c.id_Tproduto
order by 1,2,3,4;