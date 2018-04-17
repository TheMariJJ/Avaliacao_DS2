
alter table tbCliente add CONSTRAINT fk_celular 
foreign key (idCelular) references tbCelular(idCelular)

select * from tbCliente
select * from tbCelular