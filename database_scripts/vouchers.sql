insert into Vouchers (Id, Codigo, Percentual, ValorDesconto, Quantidade, TipoDescontoVoucher, DataCriacao, DataUtilizacao, DataValidade, Ativo, Utilizado)
values (NEWID(), 'PROMO-15-REAIS', NULL, 15, 0, 1, GETDATE(), null, GETDATE() + 1, 1, 0)

insert into Vouchers (Id, Codigo, Percentual, ValorDesconto, Quantidade, TipoDescontoVoucher, DataCriacao, DataUtilizacao, DataValidade, Ativo, Utilizado)
values (NEWID(), 'PROMO-10-OFF', 10, null, 50, 0, GETDATE(), null, GETDATE() + 90, 1, 0)