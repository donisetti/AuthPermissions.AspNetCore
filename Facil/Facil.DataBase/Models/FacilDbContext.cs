using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Facil.DataBase.Models;

public partial class FacilDbContext : DbContext
{
    public FacilDbContext()
    {
    }

    public FacilDbContext(DbContextOptions<FacilDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autorizado> Autorizados { get; set; }

    public virtual DbSet<Backup> Backups { get; set; }

    public virtual DbSet<Bulario> Bularios { get; set; }

    public virtual DbSet<CaixaControle> CaixaControles { get; set; }

    public virtual DbSet<CaixaLancamento> CaixaLancamentos { get; set; }

    public virtual DbSet<CaixaOperador> CaixaOperadors { get; set; }

    public virtual DbSet<Cartao> Cartaos { get; set; }

    public virtual DbSet<CartaoFidelidade> CartaoFidelidades { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cheque> Cheques { get; set; }

    public virtual DbSet<ChequeBanco> ChequeBancos { get; set; }

    public virtual DbSet<ChequeSacado> ChequeSacados { get; set; }

    public virtual DbSet<ChequeStatus> ChequeStatuses { get; set; }

    public virtual DbSet<ChequeTelefoneSacado> ChequeTelefoneSacados { get; set; }

    public virtual DbSet<ClasseTerapeutica> ClasseTerapeuticas { get; set; }

    public virtual DbSet<Classificacao> Classificacaos { get; set; }

    public virtual DbSet<ClassificacaoTipoMedicamento> ClassificacaoTipoMedicamentos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ConselhoProfissional> ConselhoProfissionals { get; set; }

    public virtual DbSet<Consignado> Consignados { get; set; }

    public virtual DbSet<ContasReceber> ContasRecebers { get; set; }

    public virtual DbSet<ContasRecebimento> ContasRecebimentos { get; set; }

    public virtual DbSet<Convenio> Convenios { get; set; }

    public virtual DbSet<CopsMovimento> CopsMovimentos { get; set; }

    public virtual DbSet<CopsMovimentoIten> CopsMovimentoItens { get; set; }

    public virtual DbSet<CozinhaPedido> CozinhaPedidos { get; set; }

    public virtual DbSet<CozinhaPedidoIten> CozinhaPedidoItens { get; set; }

    public virtual DbSet<CteCartacorrecao> CteCartacorrecaos { get; set; }

    public virtual DbSet<CteCfop> CteCfops { get; set; }

    public virtual DbSet<CteEmitenteModal> CteEmitenteModals { get; set; }

    public virtual DbSet<CteModal> CteModals { get; set; }

    public virtual DbSet<CteTomadorNaoUsar> CteTomadorNaoUsars { get; set; }

    public virtual DbSet<CteosInfnotafiscal> CteosInfnotafiscals { get; set; }

    public virtual DbSet<Devolucao> Devolucaos { get; set; }

    public virtual DbSet<DevolucaoItem> DevolucaoItems { get; set; }

    public virtual DbSet<Distribuidora> Distribuidoras { get; set; }

    public virtual DbSet<DocumentoCliente> DocumentoClientes { get; set; }

    public virtual DbSet<Emitente> Emitentes { get; set; }

    public virtual DbSet<EmpresasGrupo> EmpresasGrupos { get; set; }

    public virtual DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }

    public virtual DbSet<EntradaInsumo> EntradaInsumos { get; set; }

    public virtual DbSet<EntradaItem> EntradaItems { get; set; }

    public virtual DbSet<EntradaParametro> EntradaParametros { get; set; }

    public virtual DbSet<EntradaProduto> EntradaProdutos { get; set; }

    public virtual DbSet<EntradaUnidadeMedidum> EntradaUnidadeMedida { get; set; }

    public virtual DbSet<Entradum> Entrada { get; set; }

    public virtual DbSet<EntregaEfetuadum> EntregaEfetuada { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<EstoqueCliente> EstoqueClientes { get; set; }

    public virtual DbSet<Fabricante> Fabricantes { get; set; }

    public virtual DbSet<FabricanteDistribuidora> FabricanteDistribuidoras { get; set; }

    public virtual DbSet<Farmacologium> Farmacologia { get; set; }

    public virtual DbSet<Fisica> Fisicas { get; set; }

    public virtual DbSet<FisicaTombstone> FisicaTombstones { get; set; }

    public virtual DbSet<FormaPagamento> FormaPagamentos { get; set; }

    public virtual DbSet<FormaPagamentoImpressora> FormaPagamentoImpressoras { get; set; }

    public virtual DbSet<Fornecedore> Fornecedores { get; set; }

    public virtual DbSet<FpopVendaItem> FpopVendaItems { get; set; }

    public virtual DbSet<FpopVendum> FpopVenda { get; set; }

    public virtual DbSet<GpdFormaspagamento> GpdFormaspagamentos { get; set; }

    public virtual DbSet<GraficaServico> GraficaServicos { get; set; }

    public virtual DbSet<GraficaServicosIten> GraficaServicosItens { get; set; }

    public virtual DbSet<GraficaVendaServico> GraficaVendaServicos { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<Grupodesconto> Grupodescontos { get; set; }

    public virtual DbSet<ImpressaoEtiqueta> ImpressaoEtiquetas { get; set; }

    public virtual DbSet<ImpressaoEtiquetasTemp> ImpressaoEtiquetasTemps { get; set; }

    public virtual DbSet<Impressora> Impressoras { get; set; }

    public virtual DbSet<ImpressoraMatricial> ImpressoraMatricials { get; set; }

    public virtual DbSet<ItensConsignado> ItensConsignados { get; set; }

    public virtual DbSet<ItensGrupodesconto> ItensGrupodescontos { get; set; }

    public virtual DbSet<ItensOrcamento> ItensOrcamentos { get; set; }

    public virtual DbSet<ItensPedidoApp> ItensPedidoApps { get; set; }

    public virtual DbSet<ItensVendum> ItensVenda { get; set; }

    public virtual DbSet<Juridica> Juridicas { get; set; }

    public virtual DbSet<LinhaProduto> LinhaProdutos { get; set; }

    public virtual DbSet<Lote> Lotes { get; set; }

    public virtual DbSet<ManifestacaoDestinatario> ManifestacaoDestinatarios { get; set; }

    public virtual DbSet<Medico> Medicos { get; set; }

    public virtual DbSet<Mesa> Mesas { get; set; }

    public virtual DbSet<MesaPedido> MesaPedidos { get; set; }

    public virtual DbSet<MesaProdutoPedidoMesa> MesaProdutoPedidoMesas { get; set; }

    public virtual DbSet<MovimentoCartao> MovimentoCartaos { get; set; }

    public virtual DbSet<NfceContingencium> NfceContingencia { get; set; }

    public virtual DbSet<NfceInfnotafiscal> NfceInfnotafiscals { get; set; }

    public virtual DbSet<NfceInutilizacao> NfceInutilizacaos { get; set; }

    public virtual DbSet<NfeAliquotaIcm> NfeAliquotaIcms { get; set; }

    public virtual DbSet<NfeCartacorrecao> NfeCartacorrecaos { get; set; }

    public virtual DbSet<NfeCfop> NfeCfops { get; set; }

    public virtual DbSet<NfeCfopCorrespondencium> NfeCfopCorrespondencia { get; set; }

    public virtual DbSet<NfeDestinada> NfeDestinadas { get; set; }

    public virtual DbSet<NfeDuplicatum> NfeDuplicata { get; set; }

    public virtual DbSet<NfeFatura> NfeFaturas { get; set; }

    public virtual DbSet<NfeIbgeCidade> NfeIbgeCidades { get; set; }

    public virtual DbSet<NfeIbptaxTabela> NfeIbptaxTabelas { get; set; }

    public virtual DbSet<NfeInfnotafiscal> NfeInfnotafiscals { get; set; }

    public virtual DbSet<NfeInutilizacao> NfeInutilizacaos { get; set; }

    public virtual DbSet<NfeItem> NfeItems { get; set; }

    public virtual DbSet<NfeNotaCupom> NfeNotaCupoms { get; set; }

    public virtual DbSet<NfeRegrasIcmsDestino> NfeRegrasIcmsDestinos { get; set; }

    public virtual DbSet<NfeRegrasIcmsOrigem> NfeRegrasIcmsOrigems { get; set; }

    public virtual DbSet<NfeStCofin> NfeStCofins { get; set; }

    public virtual DbSet<NfeStIcm> NfeStIcms { get; set; }

    public virtual DbSet<NfeStIcmsCorrespondencium> NfeStIcmsCorrespondencia { get; set; }

    public virtual DbSet<NfeStIpi> NfeStIpis { get; set; }

    public virtual DbSet<NfeStPi> NfeStPis { get; set; }

    public virtual DbSet<NfeTipoContribuinte> NfeTipoContribuintes { get; set; }

    public virtual DbSet<NfeTransporte> NfeTransportes { get; set; }

    public virtual DbSet<Operadora> Operadoras { get; set; }

    public virtual DbSet<OperadoraCartao> OperadoraCartaos { get; set; }

    public virtual DbSet<Orcamento> Orcamentos { get; set; }

    public virtual DbSet<OrdemServicoProdutosOrdem> OrdemServicoProdutosOrdems { get; set; }

    public virtual DbSet<OrgaoExpedidor> OrgaoExpedidors { get; set; }

    public virtual DbSet<PafDetalheReducaoZ> PafDetalheReducaoZs { get; set; }

    public virtual DbSet<PafRelacaoReducaoZ> PafRelacaoReducaoZs { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<ParametrosCteNaousar> ParametrosCteNaousars { get; set; }

    public virtual DbSet<ParametrosFai> ParametrosFais { get; set; }

    public virtual DbSet<ParametrosFpopular> ParametrosFpopulars { get; set; }

    public virtual DbSet<ParametrosGpd> ParametrosGpds { get; set; }

    public virtual DbSet<ParametrosNfce> ParametrosNfces { get; set; }

    public virtual DbSet<ParametrosNfe> ParametrosNves { get; set; }

    public virtual DbSet<ParametrosNfse> ParametrosNfses { get; set; }

    public virtual DbSet<ParametrosRepliCadastro> ParametrosRepliCadastros { get; set; }

    public virtual DbSet<ParametrosSped> ParametrosSpeds { get; set; }

    public virtual DbSet<PedidoApp> PedidoApps { get; set; }

    public virtual DbSet<PerdaInsumo> PerdaInsumos { get; set; }

    public virtual DbSet<PerdaProduto> PerdaProdutos { get; set; }

    public virtual DbSet<Perfil> Perfils { get; set; }

    public virtual DbSet<Periodicidade> Periodicidades { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    public virtual DbSet<PessoaClassificacao> PessoaClassificacaos { get; set; }

    public virtual DbSet<PessoaTombstone> PessoaTombstones { get; set; }

    public virtual DbSet<PetAgendum> PetAgenda { get; set; }

    public virtual DbSet<PetConsultaItemNaoUsar> PetConsultaItemNaoUsars { get; set; }

    public virtual DbSet<PetConsultaServicoNaoUsar> PetConsultaServicoNaoUsars { get; set; }

    public virtual DbSet<PetConsultum> PetConsulta { get; set; }

    public virtual DbSet<PetEspecie> PetEspecies { get; set; }

    public virtual DbSet<PetFichaReceituario> PetFichaReceituarios { get; set; }

    public virtual DbSet<PetPaciente> PetPacientes { get; set; }

    public virtual DbSet<PetPelagem> PetPelagems { get; set; }

    public virtual DbSet<PetProdutoServicoNaoUsar> PetProdutoServicoNaoUsars { get; set; }

    public virtual DbSet<PetRaca> PetRacas { get; set; }

    public virtual DbSet<PetServicoNaoUsarmai> PetServicoNaoUsarmais { get; set; }

    public virtual DbSet<PetTipoRetornoVacina> PetTipoRetornoVacinas { get; set; }

    public virtual DbSet<PetVacina> PetVacinas { get; set; }

    public virtual DbSet<PetVacinacao> PetVacinacaos { get; set; }

    public virtual DbSet<PlanoConta> PlanoContas { get; set; }

    public virtual DbSet<ProAnp> ProAnps { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    public virtual DbSet<ProdutoInventario> ProdutoInventarios { get; set; }

    public virtual DbSet<ProdutoNf> ProdutoNfs { get; set; }

    public virtual DbSet<PsicoCliente> PsicoClientes { get; set; }

    public virtual DbSet<PsicoConfiguraco> PsicoConfiguracoes { get; set; }

    public virtual DbSet<RegistroEcf> RegistroEcfs { get; set; }

    public virtual DbSet<ReplicacoesPendente> ReplicacoesPendentes { get; set; }

    public virtual DbSet<ResponsavelTecnico> ResponsavelTecnicos { get; set; }

    public virtual DbSet<RestbarEnderecoEntrega> RestbarEnderecoEntregas { get; set; }

    public virtual DbSet<RestbarItensComplemento> RestbarItensComplementos { get; set; }

    public virtual DbSet<RestbarMonteSeuComplemento> RestbarMonteSeuComplementos { get; set; }

    public virtual DbSet<RestbarPedido> RestbarPedidos { get; set; }

    public virtual DbSet<RestbarPedidoProduto> RestbarPedidoProdutos { get; set; }

    public virtual DbSet<RestbarStatusTipoNum> RestbarStatusTipoNums { get; set; }

    public virtual DbSet<RestbarTipo> RestbarTipos { get; set; }

    public virtual DbSet<RotinasAuto> RotinasAutos { get; set; }

    public virtual DbSet<SaidaInsumo> SaidaInsumos { get; set; }

    public virtual DbSet<SaidaProduto> SaidaProdutos { get; set; }

    public virtual DbSet<SerCarro> SerCarros { get; set; }

    public virtual DbSet<SerCompra> SerCompras { get; set; }

    public virtual DbSet<SerCompraItem> SerCompraItems { get; set; }

    public virtual DbSet<SerCor> SerCors { get; set; }

    public virtual DbSet<SerEquipamento> SerEquipamentos { get; set; }

    public virtual DbSet<SerEquipamentoModelo> SerEquipamentoModelos { get; set; }

    public virtual DbSet<SerEquipamentoNome> SerEquipamentoNomes { get; set; }

    public virtual DbSet<SerEquipamentoServico> SerEquipamentoServicos { get; set; }

    public virtual DbSet<SerFuncionario> SerFuncionarios { get; set; }

    public virtual DbSet<SerMontadora> SerMontadoras { get; set; }

    public virtual DbSet<SerParte> SerPartes { get; set; }

    public virtual DbSet<SerServico> SerServicos { get; set; }

    public virtual DbSet<SerServicoParte> SerServicoPartes { get; set; }

    public virtual DbSet<SerServicoParteTecnico> SerServicoParteTecnicos { get; set; }

    public virtual DbSet<SerStatus> SerStatuses { get; set; }

    public virtual DbSet<SerTipoServico> SerTipoServicos { get; set; }

    public virtual DbSet<SerVeiculo> SerVeiculos { get; set; }

    public virtual DbSet<SubstanciaProduto> SubstanciaProdutos { get; set; }

    public virtual DbSet<Substancium> Substancia { get; set; }

    public virtual DbSet<Teste> Testes { get; set; }

    public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

    public virtual DbSet<TipoMotivoPerdum> TipoMotivoPerda { get; set; }

    public virtual DbSet<TipoNotafiscal> TipoNotafiscals { get; set; }

    public virtual DbSet<TipoProduto> TipoProdutos { get; set; }

    public virtual DbSet<TipoReceituario> TipoReceituarios { get; set; }

    public virtual DbSet<TipoUnidadeFarmacotecnica> TipoUnidadeFarmacotecnicas { get; set; }

    public virtual DbSet<TipoUnidadeInsumo> TipoUnidadeInsumos { get; set; }

    public virtual DbSet<TipoUsoMedicamento> TipoUsoMedicamentos { get; set; }

    public virtual DbSet<TipoVendum> TipoVenda { get; set; }

    public virtual DbSet<TransferenciaInsumo> TransferenciaInsumos { get; set; }

    public virtual DbSet<TransferenciaProduto> TransferenciaProdutos { get; set; }

    public virtual DbSet<Transportadora> Transportadoras { get; set; }

    public virtual DbSet<Tributacao> Tributacaos { get; set; }

    public virtual DbSet<UnidadeMedidum> UnidadeMedida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuarioAcesso> UsuarioAcessos { get; set; }

    public virtual DbSet<V1> V1s { get; set; }

    public virtual DbSet<VBmpo> VBmpos { get; set; }

    public virtual DbSet<VendaCpfCnpj> VendaCpfCnpjs { get; set; }

    public virtual DbSet<VendaLote> VendaLotes { get; set; }

    public virtual DbSet<VendaOrigem> VendaOrigems { get; set; }

    public virtual DbSet<VendaPagamento> VendaPagamentos { get; set; }

    public virtual DbSet<VendaVdaCupomNfe> VendaVdaCupomNves { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    public virtual DbSet<Vendum> Venda { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Note-val\\sqlserver2014;Initial Catalog=valdirvasis;User Id=sa; Password=csystems;Integrated Security=False;Persist Security Info=True;Encrypt=false;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autorizado>(entity =>
        {
            entity.HasOne(d => d.PesCodigoNavigation).WithMany().HasConstraintName("FK_AUTORIZADO_PESSOA");
        });

        modelBuilder.Entity<Backup>(entity =>
        {
            entity.Property(e => e.BakCodigo).ValueGeneratedNever();
            entity.Property(e => e.BakData).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.BakParidade).IsFixedLength();
            entity.Property(e => e.BakStatus).IsFixedLength();
            entity.Property(e => e.BakStopBits).IsFixedLength();
            entity.Property(e => e.BakTefNumeroPdv).IsFixedLength();
            entity.Property(e => e.BakViasReimpressao)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
        });

        modelBuilder.Entity<Bulario>(entity =>
        {
            entity.HasKey(e => e.BulCodigo).HasName("BULARIO_PK");

            entity.Property(e => e.BulCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<CaixaControle>(entity =>
        {
            entity.HasKey(e => e.CxcCodigo).HasName("CAIXA_CONTROLE_PK");

            entity.Property(e => e.CxcCodigo).ValueGeneratedNever();
            entity.Property(e => e.CxcDataAbertura).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CxcDataFechamento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CxcSaldoFinal).HasDefaultValueSql("((0))");
            entity.Property(e => e.CxcSaldoInicial).HasDefaultValueSql("((0))");
            entity.Property(e => e.CxcSaldoMovimentacao).HasDefaultValueSql("((0))");
            entity.Property(e => e.CxcValorEntrada).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<CaixaLancamento>(entity =>
        {
            entity.HasIndex(e => e.CxlCodigo, "IX_MOVIMENTO_DIARIO").HasFillFactor(90);

            entity.Property(e => e.CxlCodigo).ValueGeneratedNever();
            entity.Property(e => e.CxlDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CxlValorLancamento).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.CxoCodigoNavigation).WithMany(p => p.CaixaLancamentos).HasConstraintName("FK_CAIXA_LANCAMENTO_CAIXA_OPERADOR");

            entity.HasOne(d => d.PctCodigoReduzidoNavigation).WithMany(p => p.CaixaLancamentos).HasConstraintName("FK_MOVIMENTO_DIARIO_PLANO_CONTAS");
        });

        modelBuilder.Entity<CaixaOperador>(entity =>
        {
            entity.HasKey(e => e.CxoCodigo).HasName("PK_Table_1");

            entity.Property(e => e.CxoCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<CartaoFidelidade>(entity =>
        {
            entity.HasKey(e => e.CarfCodigo).HasName("PK_CARTAO_FIDELIDADE_CARF_Codigo");

            entity.Property(e => e.CarfCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CatCodigo).HasName("Categoria_PK");

            entity.Property(e => e.CatCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Cheque>(entity =>
        {
            entity.Property(e => e.CheCodigo).ValueGeneratedNever();
            entity.Property(e => e.CheDataBase).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CheDataMovimento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CheDataVencimento).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.Cheques).HasConstraintName("FK_CHEQUE_PESSOA");

            entity.HasOne(d => d.SacCodigoNavigation).WithMany(p => p.Cheques)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHEQUE_CHEQUE_SACADO");

            entity.HasOne(d => d.StsCodigoNavigation).WithMany(p => p.Cheques).HasConstraintName("FK_CHEQUE_CHEQUE_STATUS");

            entity.HasOne(d => d.UsrCodigoNavigation).WithMany(p => p.Cheques)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHEQUE_USUARIO");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.Cheques)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CHEQUE_VENDA");
        });

        modelBuilder.Entity<ChequeBanco>(entity =>
        {
            entity.Property(e => e.BanCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChequeSacado>(entity =>
        {
            entity.Property(e => e.SacCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.BanCodigoNavigation).WithMany(p => p.ChequeSacados).HasConstraintName("FK_CHEQUE_SACADO_CHEQUE_BANCO");
        });

        modelBuilder.Entity<ChequeStatus>(entity =>
        {
            entity.Property(e => e.StsCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ChequeTelefoneSacado>(entity =>
        {
            entity.Property(e => e.TesCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.SacCodigoNavigation).WithMany(p => p.ChequeTelefoneSacados).HasConstraintName("FK_CHEQUE_TELEFONE_SACADO_CHEQUE_SACADO");
        });

        modelBuilder.Entity<ClasseTerapeutica>(entity =>
        {
            entity.Property(e => e.ClatCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Classificacao>(entity =>
        {
            entity.HasKey(e => e.ClaCodigo).HasName("Classificacao_PK");

            entity.Property(e => e.ClaCodigo).ValueGeneratedNever();
            entity.Property(e => e.ClaDescAprazoAtivo).IsFixedLength();
            entity.Property(e => e.ClaDescAvistaAtivo).IsFixedLength();
            entity.Property(e => e.ClaDtaFinalDescAprazo).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ClaDtaFinalDescAvista).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ClaDtaInicioDescAprazo).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ClaDtaInicioDescAvista).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ClaPctDescAprazo).HasDefaultValueSql("((0))");
            entity.Property(e => e.ClaPctDescAvista).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<ClassificacaoTipoMedicamento>(entity =>
        {
            entity.Property(e => e.ClatmedCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToView("cliente");
        });

        modelBuilder.Entity<ConselhoProfissional>(entity =>
        {
            entity.HasKey(e => e.CalSigla).HasName("PK_CONSELHO_PROFISSIONAL_1");
        });

        modelBuilder.Entity<Consignado>(entity =>
        {
            entity.Property(e => e.CdoCodigo).ValueGeneratedNever();
            entity.Property(e => e.CdoDataFechamento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CdoDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.Consignados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONSIGNADO_PESSOA");
        });

        modelBuilder.Entity<ContasReceber>(entity =>
        {
            entity.Property(e => e.CreCodigo).ValueGeneratedNever();
            entity.Property(e => e.CreDataAbatimento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CreDataEmCobranca).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CreDataEstorno).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CreDataRecebimento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CreDataVencimento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CrePctDescontoRecebimento).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreSituacao).IsFixedLength();
            entity.Property(e => e.CreValorAbatido).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreValorBruto).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreValorDescontoRecebimento).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreValorJurosAbatidos).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreValorJurosRestantes).HasDefaultValueSql("((0))");
            entity.Property(e => e.CreValorPagamento).HasDefaultValueSql("((0))");
            entity.Property(e => e.VdaValorCredito).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.ContasRecebers).HasConstraintName("FK_CONTAS_RECEBER_PESSOA");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.ContasRecebers)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTAS_RECEBER_VENDA");
        });

        modelBuilder.Entity<ContasRecebimento>(entity =>
        {
            entity.Property(e => e.CorCodigo).ValueGeneratedNever();
            entity.Property(e => e.CorDataAbatido).HasDefaultValueSql("('01-01-1900')");
            entity.Property(e => e.CorDataEstorno).HasDefaultValueSql("('01-01-1900')");
            entity.Property(e => e.CorDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.CorDataRecebimento).HasDefaultValueSql("('01-01-1900')");
            entity.Property(e => e.CorJuroAbatido).HasDefaultValueSql("((0))");
            entity.Property(e => e.CorJuroRestante).HasDefaultValueSql("((0))");
            entity.Property(e => e.CorValorAbatido).HasDefaultValueSql("((0))");
            entity.Property(e => e.CorValorDesconto).HasDefaultValueSql("((0))");
            entity.Property(e => e.CorValorJurosRecebidos).HasDefaultValueSql("((0))");
            entity.Property(e => e.CorValorRecebido).HasDefaultValueSql("((0))");
            entity.Property(e => e.UsuCodigo).HasComment("usuario estorno");

            entity.HasOne(d => d.CreCodigoNavigation).WithMany(p => p.ContasRecebimentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CONTAS_RECEBIMENTO_CONTAS_RECEBER");
        });

        modelBuilder.Entity<Convenio>(entity =>
        {
            entity.HasKey(e => e.CvnCodigo).HasName("CONVENIO_PK");

            entity.Property(e => e.CvnCodigo).ValueGeneratedNever();
            entity.Property(e => e.CvnCobrarJuros).IsFixedLength();
            entity.Property(e => e.CvnDataExclusao).HasDefaultValueSql("(((1)/(1))/(1900))");
        });

        modelBuilder.Entity<CopsMovimento>(entity =>
        {
            entity.HasKey(e => e.MovCodigo).HasName("PK_COPS_Movimento");

            entity.Property(e => e.MovCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.MedCodigoNavigation).WithMany(p => p.CopsMovimentos).HasConstraintName("FK_COPS_MOVIMENTO_MEDICOS");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.CopsMovimentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COPS_MOVIMENTO_PESSOA");

            entity.HasOne(d => d.UsuCodigoNavigation).WithMany(p => p.CopsMovimentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COPS_MOVIMENTO_USUARIO");
        });

        modelBuilder.Entity<CopsMovimentoIten>(entity =>
        {
            entity.Property(e => e.ImoCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.MovCodigoNavigation).WithMany(p => p.CopsMovimentoItens)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_COPS_MOVIMENTO_ITENS_COPS_MOVIMENTO");
        });

        modelBuilder.Entity<CozinhaPedido>(entity =>
        {
            entity.Property(e => e.CozCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<CozinhaPedidoIten>(entity =>
        {
            entity.Property(e => e.IcozCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<CteCfop>(entity =>
        {
            entity.HasKey(e => e.CfopCodigo).HasName("PK_CteCFOP");
        });

        modelBuilder.Entity<CteEmitenteModal>(entity =>
        {
            entity.HasOne(d => d.EmiCodigoNavigation).WithMany(p => p.CteEmitenteModals)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTE_EMITENTE_MODAL_EMITENTE");
        });

        modelBuilder.Entity<CteModal>(entity =>
        {
            entity.Property(e => e.ModCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EmiCodigoNavigation).WithMany(p => p.CteModals).HasConstraintName("FK_CTE_MODAL_EMITENTE");
        });

        modelBuilder.Entity<CteTomadorNaoUsar>(entity =>
        {
            entity.HasKey(e => e.TomCodigo).HasName("PK_CTE_TOMADOR");

            entity.Property(e => e.TomCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<CteosInfnotafiscal>(entity =>
        {
            entity.Property(e => e.CteoCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Devolucao>(entity =>
        {
            entity.Property(e => e.DevCodigo).ValueGeneratedNever();
            entity.Property(e => e.PesCodigo).HasDefaultValueSql("((0))");
            entity.Property(e => e.UsuCodigoFechamento).HasDefaultValueSql("((0))");
            entity.Property(e => e.UsuCodigoMovimento).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.EmpCodigoNavigation).WithMany(p => p.Devolucaos).HasConstraintName("FK_DEVOLUCAO_EMPRESAS_GRUPO");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.Devolucaos).HasConstraintName("FK_DEVOLUCAO_PESSOA");

            entity.HasOne(d => d.UsuCodigoMovimentoNavigation).WithMany(p => p.Devolucaos).HasConstraintName("FK_DEVOLUCAO_USUARIO");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.Devolucaos).HasConstraintName("FK_DEVOLUCAO_VENDA");
        });

        modelBuilder.Entity<DevolucaoItem>(entity =>
        {
            entity.Property(e => e.DviCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.DevCodigoNavigation).WithMany(p => p.DevolucaoItems).HasConstraintName("FK_DEVOLUCAO_ITEM_DEVOLUCAO");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.DevolucaoItems).HasConstraintName("FK_DEVOLUCAO_ITEM_PRODUTO");
        });

        modelBuilder.Entity<Distribuidora>(entity =>
        {
            entity.HasKey(e => e.DisCodigo).HasName("PK_DISTRIBUIDORAS");

            entity.Property(e => e.DisCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<DocumentoCliente>(entity =>
        {
            entity.Property(e => e.DcliCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.OexCodigoNavigation).WithMany(p => p.DocumentoClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOCUMENTO_CLIENTES_ORGAO_EXPEDIDOR");

            entity.HasOne(d => d.PcliCodigoNavigation).WithMany(p => p.DocumentoClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOCUMENTO_CLIENTES_PSICO_CLIENTE");

            entity.HasOne(d => d.TdoCodigoNavigation).WithMany(p => p.DocumentoClientes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOCUMENTO_CLIENTES_TIPO_DOCUMENTOS");
        });

        modelBuilder.Entity<Emitente>(entity =>
        {
            entity.Property(e => e.EmiCodigo).ValueGeneratedNever();
            entity.Property(e => e.EmiWebServiceUfEmitenteCte).IsFixedLength();
        });

        modelBuilder.Entity<EmpresasGrupo>(entity =>
        {
            entity.Property(e => e.EmpCodigo).ValueGeneratedNever();
            entity.Property(e => e.EmpAliqIcmssn).HasComment("Alíquota ICMS Simples Nacional");
            entity.Property(e => e.EmpPerfil).IsFixedLength();
            entity.Property(e => e.EmpSaldoContaCaixa).HasDefaultValueSql("((0))");
            entity.Property(e => e.EmpTipoEmissao).IsFixedLength();
            entity.Property(e => e.EmpUltimaNota).HasComment("Número da última nota fiscal eletrônica emitida");
            entity.Property(e => e.EmpWebServiceUfEmitente).IsFixedLength();
            entity.Property(e => e.EmpWebServiceUfEmitenteNfce).IsFixedLength();
        });

        modelBuilder.Entity<EnderecoEntrega>(entity =>
        {
            entity.Property(e => e.EtgCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.EnderecoEntregas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENDERECO_ENTREGA_PESSOA");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.EnderecoEntregas).HasConstraintName("FK_ENDERECO_ENTREGA_VENDA");
        });

        modelBuilder.Entity<EntradaInsumo>(entity =>
        {
            entity.Property(e => e.EisCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.SubCodigoNavigation).WithMany(p => p.EntradaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTRADA_INSUMOS_SUBSTANCIA");

            entity.HasOne(d => d.TnfCodigoNavigation).WithMany(p => p.EntradaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTRADA_INSUMOS_TIPO_NOTAFISCAL");

            entity.HasOne(d => d.TuiCodigoNavigation).WithMany(p => p.EntradaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTRADA_INSUMOS_TIPO_UNIDADE_INSUMO");
        });

        modelBuilder.Entity<EntradaItem>(entity =>
        {
            entity.HasKey(e => e.EtiCodigo).HasName("PK_ENTRADAS_ITENS");

            entity.Property(e => e.EtiCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EntCodigoNavigation).WithMany(p => p.EntradaItems).HasConstraintName("entrada_fk");
        });

        modelBuilder.Entity<EntradaProduto>(entity =>
        {
            entity.HasKey(e => e.EntCodigo).HasName("ENTRADA_PRODUTOS_PK");

            entity.Property(e => e.EntCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ForCodigoProdutoNavigation).WithMany(p => p.EntradaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTRADA_PRODUTOS_FORNECEDORES");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.EntradaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTRADA_PRODUTOS_PRODUTO");

            entity.HasOne(d => d.TnfCodigoNavigation).WithMany(p => p.EntradaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTRADA_PRODUTOS_TIPO_NOTAFISCAL");
        });

        modelBuilder.Entity<EntradaUnidadeMedidum>(entity =>
        {
            entity.Property(e => e.EunCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.UniCodigoNavigation).WithMany(p => p.EntradaUnidadeMedida).HasConstraintName("FK_ENTRADA_UNIDADE_MEDIDA_UNIDADE_MEDIDA");
        });

        modelBuilder.Entity<Entradum>(entity =>
        {
            entity.Property(e => e.EntCodigo).ValueGeneratedNever();
            entity.Property(e => e.EntAproveitarIcms).HasDefaultValueSql("((1))");
            entity.Property(e => e.EntDataEncerramento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.EntDataEntrada).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.EntValorNota).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.UsuCodigoNavigation).WithMany(p => p.Entrada).HasConstraintName("FK_ENTRADA_USUARIO");
        });

        modelBuilder.Entity<EntregaEfetuadum>(entity =>
        {
            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.EntregaEfetuada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ENTREGA_EFETUADA_PESSOA");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.Property(e => e.EstCodigo).ValueGeneratedNever();
            entity.Property(e => e.EstSigla).IsFixedLength();
        });

        modelBuilder.Entity<EstoqueCliente>(entity =>
        {
            entity.Property(e => e.IvdCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Fabricante>(entity =>
        {
            entity.HasKey(e => e.FabCodigo).HasName("Fabricante_PK");

            entity.Property(e => e.FabCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<FabricanteDistribuidora>(entity =>
        {
            entity.Property(e => e.IdCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.DisCodigoNavigation).WithMany(p => p.FabricanteDistribuidoras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FABRICANTE_DISTRIBUIDORA_DISTRIBUIDORAS");

            entity.HasOne(d => d.FabCodigoNavigation).WithMany(p => p.FabricanteDistribuidoras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FABRICANTE_DISTRIBUIDORA_FABRICANTE");
        });

        modelBuilder.Entity<Farmacologium>(entity =>
        {
            entity.HasKey(e => e.FiaCodigo).HasName("FARMACOLOGIA_PK");

            entity.Property(e => e.FiaCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Fisica>(entity =>
        {
            entity.HasKey(e => e.PesCodigo).HasName("Fisica_PK");

            entity.ToTable("FISICA", tb =>
                {
                    tb.HasTrigger("FISICA_DeletionTrigger");
                    tb.HasTrigger("FISICA_InsertTrigger");
                    tb.HasTrigger("FISICA_UpdateTrigger");
                });

            entity.Property(e => e.PesCodigo).ValueGeneratedNever();
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.FisDataNascimentoConjuge).HasDefaultValueSql("('01/01/1900')");
            entity.Property(e => e.FisDtaNascimento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.FisOrgaoEmissor).IsFixedLength();
            entity.Property(e => e.FisSalarioConjuge).HasDefaultValueSql("((0))");
            entity.Property(e => e.FisSalarioLocalTrabalho).HasDefaultValueSql("((0))");
            entity.Property(e => e.FisSexo).IsFixedLength();
            entity.Property(e => e.LastEditDate).HasDefaultValueSql("(getutcdate())");

            entity.HasOne(d => d.PesCodigoNavigation).WithOne(p => p.Fisica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pessoa_Fisica_FK1");
        });

        modelBuilder.Entity<FisicaTombstone>(entity =>
        {
            entity.HasKey(e => e.PesCodigo).HasName("PKDEL_FISICA_Tombstone_PES_Codigo");

            entity.Property(e => e.PesCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<FormaPagamento>(entity =>
        {
            entity.HasKey(e => e.FpgCodigo).HasName("PK_FORMA_PAGTO");

            entity.Property(e => e.FpgCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.PctCodigoReduzidoNavigation).WithMany(p => p.FormaPagamentos).HasConstraintName("FK_FORMA_PAGTO_PLANO_CONTAS");
        });

        modelBuilder.Entity<FormaPagamentoImpressora>(entity =>
        {
            entity.Property(e => e.FpiCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.BakCodigoNavigation).WithMany(p => p.FormaPagamentoImpressoras).HasConstraintName("FK_FORMA_PAGAMENTO_IMPRESSORA_BACKUPS");

            entity.HasOne(d => d.FpgCodigoNavigation).WithMany(p => p.FormaPagamentoImpressoras).HasConstraintName("FK_FORMA_PAGAMENTO_IMPRESSORA_FORMA_PAGAMENTO");

            entity.HasOne(d => d.ImpCodigoNavigation).WithMany(p => p.FormaPagamentoImpressoras).HasConstraintName("FK_FORMA_PAGAMENTO_IMPRESSORA_IMPRESSORA");
        });

        modelBuilder.Entity<Fornecedore>(entity =>
        {
            entity.Property(e => e.ForCodigo).ValueGeneratedNever();
            entity.Property(e => e.ForTipoCadastro).IsFixedLength();

            entity.HasOne(d => d.PctCodigoReduzidoNavigation).WithMany(p => p.Fornecedores).HasConstraintName("FK_FORNECEDORES_PLANO_CONTAS");
        });

        modelBuilder.Entity<FpopVendaItem>(entity =>
        {
            entity.HasKey(e => e.FpoiCodigo).HasName("PK_FPOP_VendaItem");

            entity.Property(e => e.FpoiCodigo).ValueGeneratedNever();
            entity.Property(e => e.FpoiEstorno).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.FpovCodigoNavigation).WithMany(p => p.FpopVendaItems).HasConstraintName("FK_FPOP_VendaItem_FPOP_VENDA");
        });

        modelBuilder.Entity<FpopVendum>(entity =>
        {
            entity.HasKey(e => e.FpovCodigo).HasName("PK_FPOPULAR_VENDA");

            entity.Property(e => e.FpovCodigo).ValueGeneratedNever();
            entity.Property(e => e.FpovDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.FpovStatus).IsFixedLength();
        });

        modelBuilder.Entity<GpdFormaspagamento>(entity =>
        {
            entity.HasKey(e => e.GpdfpgCodigo).HasName("PK_GPD_FORMASPAGAMENTO_GPDFPG_Codigo");

            entity.Property(e => e.GpdfpgCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<GraficaServico>(entity =>
        {
            entity.HasKey(e => e.GrafsCodigo).HasName("PK_GRAFICA_SERVICOS_1");

            entity.Property(e => e.GrafsCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<GraficaServicosIten>(entity =>
        {
            entity.HasKey(e => e.GrafsiCodigo).HasName("PK_GRAFICA_SERVICOS");

            entity.Property(e => e.GrafsiCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<GraficaVendaServico>(entity =>
        {
            entity.Property(e => e.GrafvsCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.HasOne(d => d.TioCodigoNavigation).WithMany(p => p.Grupos).HasConstraintName("FK_GRUPO_TIPO_RECEITUARIO");
        });

        modelBuilder.Entity<Grupodesconto>(entity =>
        {
            entity.HasKey(e => e.GpdCodigo).HasName("PK_GRUPODESCONTO_GPD_Codigo");

            entity.Property(e => e.GpdCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ImpressaoEtiqueta>(entity =>
        {
            entity.Property(e => e.EtqCodigo).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ImpressaoEtiquetasTemp>(entity =>
        {
            entity.Property(e => e.EttCodigo).ValueGeneratedNever();
            entity.Property(e => e.EttDataEntrada).HasDefaultValueSql("(((1)/(1))/(1900))");
        });

        modelBuilder.Entity<Impressora>(entity =>
        {
            entity.HasKey(e => e.ImpCodigo).HasName("PK_IMPRESSORAS");

            entity.Property(e => e.ImpCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ImpressoraMatricial>(entity =>
        {
            entity.Property(e => e.ImpCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItensConsignado>(entity =>
        {
            entity.Property(e => e.IcdCodigo).ValueGeneratedNever();
            entity.Property(e => e.IcdCustoFabrica).HasDefaultValueSql("((0))");
            entity.Property(e => e.IcdCustoReal).HasDefaultValueSql("((0))");
            entity.Property(e => e.IcdQuantidade).HasDefaultValueSql("((0))");
            entity.Property(e => e.IcdValorVendaUnitario).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.ItensConsignados).HasConstraintName("FK_ITENS_CONSIGNADO_PRODUTO");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.ItensConsignados)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITENS_CONSIGNADO_VENDA");
        });

        modelBuilder.Entity<ItensGrupodesconto>(entity =>
        {
            entity.HasKey(e => e.IgpdCodigo).HasName("PK_ITENS_GRUPODESCONTO_IGPD_Codigo");

            entity.Property(e => e.IgpdCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItensOrcamento>(entity =>
        {
            entity.Property(e => e.IocCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ItensVendum>(entity =>
        {
            entity.Property(e => e.IvdCodigo).ValueGeneratedNever();
            entity.Property(e => e.IvdComissaoPaga).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdCustoFabrica).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdCustoReal).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdDataEstorno).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.IvdDataVencimento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.IvdOrigemIcms).IsFixedLength();
            entity.Property(e => e.IvdPctComissao).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdPctDescontoProduto).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdPctDescontoTotal).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdQuantidade).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdQuantidadeEstorno).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdValorDescontoDevolvido).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdValorDescontoItemDevolucao).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdValorDescontoProduto).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdValorDevolvido).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdValorVendaFinal).HasDefaultValueSql("((0))");
            entity.Property(e => e.IvdValorVendaUnitario).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.IvdSerTecnicoNavigation).WithMany(p => p.ItensVenda).HasConstraintName("FK_ITENS_VENDA_USUARIO");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.ItensVenda).HasConstraintName("FK_ITENS_VENDA_PRODUTO");

            entity.HasOne(d => d.SerparCodigoNavigation).WithMany(p => p.ItensVenda).HasConstraintName("FK_ITENS_VENDA_SER_SERVICO_PARTE");

            entity.HasOne(d => d.TpvCodigoNavigation).WithMany(p => p.ItensVenda).HasConstraintName("FK_ITENS_VENDA_TIPO_VENDA");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.ItensVenda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ITENS_VENDA_VENDA");
        });

        modelBuilder.Entity<Juridica>(entity =>
        {
            entity.HasKey(e => e.PesCodigo).HasName("Juridica_PK");

            entity.Property(e => e.PesCodigo).ValueGeneratedNever();
            entity.Property(e => e.JurDtaFundacao).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.PesCodigoNavigation).WithOne(p => p.Juridica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Pessoa_Juridica_FK1");
        });

        modelBuilder.Entity<LinhaProduto>(entity =>
        {
            entity.HasKey(e => e.LinCodigo).HasName("LINHA_PRODUTO_PK");

            entity.Property(e => e.LinCodigo).ValueGeneratedNever();
            entity.Property(e => e.LinPctComissao).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<Lote>(entity =>
        {
            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.Lotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LOTE_PRODUTO");
        });

        modelBuilder.Entity<ManifestacaoDestinatario>(entity =>
        {
            entity.HasKey(e => e.MdCodigo).HasName("PK_MANIFESTACAO_DESTINATARIO_MD_Codigo");

            entity.HasOne(d => d.DestCodigoNavigation).WithMany(p => p.ManifestacaoDestinatarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MANIFESTACAO_DESTINATARIO_NFe_DESTINADAS");
        });

        modelBuilder.Entity<Medico>(entity =>
        {
            entity.Property(e => e.MedCodigo).ValueGeneratedNever();
            entity.Property(e => e.EstSigla).IsFixedLength();

            entity.HasOne(d => d.CalSiglaNavigation).WithMany(p => p.Medicos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MEDICOS_CONSELHO_PROFISSIONAL");
        });

        modelBuilder.Entity<Mesa>(entity =>
        {
            entity.Property(e => e.MsaCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<MesaPedido>(entity =>
        {
            entity.Property(e => e.PpzCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.MsaCodigoNavigation).WithMany(p => p.MesaPedidos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MESA_PEDIDO_MESA_PEDIDO");
        });

        modelBuilder.Entity<MesaProdutoPedidoMesa>(entity =>
        {
            entity.Property(e => e.MppCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.PpzCodigoNavigation).WithMany(p => p.MesaProdutoPedidoMesas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MESA_PRODUTO_PEDIDO_MESA_MESA_PEDIDO");
        });

        modelBuilder.Entity<MovimentoCartao>(entity =>
        {
            entity.Property(e => e.CreCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<NfceContingencium>(entity =>
        {
            entity.HasKey(e => e.ConCodigo).HasName("PK__NFCe_CON__009926B1BA922569");

            entity.Property(e => e.ConCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.NfceCodigoNavigation).WithMany(p => p.NfceContingencia).HasConstraintName("FK_NFCE_CONTINGENCIA_NFCE_INFNOTAFISCAL");
        });

        modelBuilder.Entity<NfceInfnotafiscal>(entity =>
        {
            entity.HasKey(e => e.NfceCodigo).HasName("PK__NFCe_INFNOTAFISC__391958F9");

            entity.Property(e => e.NfceCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<NfceInutilizacao>(entity =>
        {
            entity.HasKey(e => e.InuCodigo).HasName("PK__NFCe_INU__DBD0F25400367B9C");

            entity.Property(e => e.InuCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.UsrCodigoNavigation).WithMany(p => p.NfceInutilizacaos).HasConstraintName("FK__NFCe_INUT__USR_C__7775B2CE");
        });

        modelBuilder.Entity<NfeAliquotaIcm>(entity =>
        {
            entity.Property(e => e.UfOrigem).IsFixedLength();
            entity.Property(e => e.UfDestino).IsFixedLength();
        });

        modelBuilder.Entity<NfeCfop>(entity =>
        {
            entity.HasKey(e => e.CfopCodigo).HasName("PK_CFOP");
        });

        modelBuilder.Entity<NfeCfopCorrespondencium>(entity =>
        {
            entity.HasOne(d => d.CfopNfFornecedorNavigation).WithOne(p => p.NfeCfopCorrespondencium)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NFe_CFOP_CORRESPONDENCIA_NFe_CFOP");
        });

        modelBuilder.Entity<NfeDestinada>(entity =>
        {
            entity.HasKey(e => e.DestCodigo).HasName("PK__NFe_DESTINADAS__3F27380A");
        });

        modelBuilder.Entity<NfeIbgeCidade>(entity =>
        {
            entity.Property(e => e.CidCodigo).ValueGeneratedNever();
            entity.Property(e => e.CidSiglaEstado).IsFixedLength();
        });

        modelBuilder.Entity<NfeIbptaxTabela>(entity =>
        {
            entity.Property(e => e.IbptAliquotaImportacao).HasComment("A Aliquota de importacao é utilizada quando a origem do produto for de fora do brasil");
            entity.Property(e => e.IbptAliquotaNacional).HasComment("A Aliquota nacional é utilizada quando o produto for de origem brasileira. ");
            entity.Property(e => e.IbptCodigo).ValueGeneratedOnAdd();
            entity.Property(e => e.IbptTabela).HasComment("0 para NCM\r\n1 para NBS (servicos)\r\n2 para Item da LC 116");
        });

        modelBuilder.Entity<NfeInfnotafiscal>(entity =>
        {
            entity.Property(e => e.NfeCodigo).ValueGeneratedNever();
            entity.Property(e => e.NfeSituacaoEnvio)
                .IsFixedLength()
                .HasComment("A - Aberto E - Enviado C - Cancelado");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.NfeInfnotafiscals).HasConstraintName("FK_NFe_Pessoal");
        });

        modelBuilder.Entity<NfeInutilizacao>(entity =>
        {
            entity.HasKey(e => e.InuCodigo).HasName("PK__NFe_INUT__DBD0F254ECA93160");

            entity.Property(e => e.InuCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.UsrCodigoNavigation).WithMany(p => p.NfeInutilizacaos).HasConstraintName("FK__NFe_INUTI__USR_C__7A521F79");
        });

        modelBuilder.Entity<NfeItem>(entity =>
        {
            entity.Property(e => e.NfiCodigo).ValueGeneratedNever();
            entity.Property(e => e.NfiOrigemIcms).IsFixedLength();
            entity.Property(e => e.NfiQuantidade).HasDefaultValueSql("((0))");
            entity.Property(e => e.NfiValorDesconto).HasDefaultValueSql("((0))");
            entity.Property(e => e.NfiValorFrete).HasDefaultValueSql("((0))");
            entity.Property(e => e.NfiValorOutro).HasDefaultValueSql("((0))");
            entity.Property(e => e.NfiValorSeguro).HasDefaultValueSql("((0))");
            entity.Property(e => e.NfiValorUnitario).HasDefaultValueSql("((0))");
        });

        modelBuilder.Entity<NfeNotaCupom>(entity =>
        {
            entity.Property(e => e.NfcCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.NfeCodigoNavigation).WithMany(p => p.NfeNotaCupoms).HasConstraintName("FK_NFe_NOTA_CUPOM_NFe_INFNOTAFISCAL");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.NfeNotaCupoms).HasConstraintName("FK_NFe_NOTA_CUPOM_VENDA");
        });

        modelBuilder.Entity<NfeRegrasIcmsDestino>(entity =>
        {
            entity.Property(e => e.RicmsUfDestino).IsFixedLength();
        });

        modelBuilder.Entity<NfeRegrasIcmsOrigem>(entity =>
        {
            entity.Property(e => e.RicmsUfOrigem).IsFixedLength();
        });

        modelBuilder.Entity<NfeStCofin>(entity =>
        {
            entity.HasKey(e => e.StcofCodigo).HasName("PK_SITUACAO_TRIBUTARIA_COFINS");
        });

        modelBuilder.Entity<NfeStIpi>(entity =>
        {
            entity.HasKey(e => e.StipiCodigo).HasName("PK_SITUACAO_TRIBUTARIA_IPI");
        });

        modelBuilder.Entity<NfeStPi>(entity =>
        {
            entity.HasKey(e => e.StpisCodigo).HasName("PK_SITUACAO_TRIBUTARIA_PIS");
        });

        modelBuilder.Entity<NfeTipoContribuinte>(entity =>
        {
            entity.HasKey(e => e.IndIedestCodigo).HasName("PK_NFe_TipoContribuinte");

            entity.Property(e => e.IndIedestCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<NfeTransporte>(entity =>
        {
            entity.Property(e => e.NtraModalidadeFrete).IsFixedLength();
            entity.Property(e => e.NtraUfPlaca).IsFixedLength();
        });

        modelBuilder.Entity<Operadora>(entity =>
        {
            entity.Property(e => e.OpeCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Orcamento>(entity =>
        {
            entity.Property(e => e.OrcCodigo).ValueGeneratedNever();
            entity.Property(e => e.OrcDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.Orcamentos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ORCAMENTO_PESSOA");
        });

        modelBuilder.Entity<OrdemServicoProdutosOrdem>(entity =>
        {
            entity.Property(e => e.IvdCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<OrgaoExpedidor>(entity =>
        {
            entity.Property(e => e.OexCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PafDetalheReducaoZ>(entity =>
        {
            entity.Property(e => e.DtredzCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PafRelacaoReducaoZ>(entity =>
        {
            entity.Property(e => e.RedzCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.Property(e => e.ParCount).HasDefaultValueSql("((0))");
            entity.Property(e => e.ParDescontoFechamentoVenda).HasDefaultValueSql("((0))");
            entity.Property(e => e.ParImprimePromissoriaCupom40).HasDefaultValueSql("((0))");
            entity.Property(e => e.ParMostraMensagemAtendimento).HasDefaultValueSql("((1))");
            entity.Property(e => e.ParReceberCobraJuros).HasDefaultValueSql("((1))");
            entity.Property(e => e.ParReceberDiasCobrarJuros).HasDefaultValueSql("((0))");
            entity.Property(e => e.ParReceberPctJuros).HasDefaultValueSql("((0))");
            entity.Property(e => e.ParUsaNf).IsFixedLength();
            entity.Property(e => e.ParVendaEstoqueNegativo).HasDefaultValueSql("((1))");
        });

        modelBuilder.Entity<ParametrosCteNaousar>(entity =>
        {
            entity.HasKey(e => e.CteCodigo).HasName("PK_PARAMETROS_CTE");

            entity.Property(e => e.CteCodigo).ValueGeneratedNever();
            entity.Property(e => e.CteUfEmitenteWebService).IsFixedLength();
        });

        modelBuilder.Entity<ParametrosFai>(entity =>
        {
            entity.HasKey(e => e.ParfCodigo).HasName("PK_PARAMETRO_FAI");

            entity.Property(e => e.ParfCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ParametrosGpd>(entity =>
        {
            entity.HasKey(e => e.PgpdCodigo).HasName("PK_PARAMETROS_GPD_PGPD_Codigo");
        });

        modelBuilder.Entity<ParametrosNfce>(entity =>
        {
            entity.Property(e => e.EmpCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EmpCodigoNavigation).WithOne(p => p.ParametrosNfce)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PARAMETROS_NFCE_EMPRESAS_GRUPO");
        });

        modelBuilder.Entity<ParametrosNfe>(entity =>
        {
            entity.Property(e => e.EmpCodigo).ValueGeneratedNever();
            entity.Property(e => e.NfeDirPdfDanfe).HasComment("Diretório para onde será exportado o pdf da Danfe");
            entity.Property(e => e.NfeDirXmlEnvio).HasComment("Diretório para onde será exportado o xml de envio");
            entity.Property(e => e.NfeDirXmlRecebido).HasComment("Diretório para onde será exportado o xml recebido após o envio");
            entity.Property(e => e.NfeJustCancelamento).HasComment("Justificativa padrão de cancelamento ");
        });

        modelBuilder.Entity<ParametrosNfse>(entity =>
        {
            entity.HasKey(e => e.NfseCodigo).HasName("PK__PARAMETR__BA8F06FE8CEDBA86");

            entity.Property(e => e.NfseCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EmpCodigoNavigation).WithMany(p => p.ParametrosNfses).HasConstraintName("FK_PARAMETROS_NFSE_EMPRESAS_GRUPO");
        });

        modelBuilder.Entity<ParametrosRepliCadastro>(entity =>
        {
            entity.HasKey(e => e.RepCodigo).HasName("pk_REP_CODIGO");

            entity.Property(e => e.RepCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ParametrosSped>(entity =>
        {
            entity.HasOne(d => d.EmpCodigoNavigation).WithMany().HasConstraintName("FK_PARAMETROS_SPED_EMPRESAS_GRUPO");
        });

        modelBuilder.Entity<PerdaInsumo>(entity =>
        {
            entity.Property(e => e.PinCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ForCodigoInsumoNavigation).WithMany(p => p.PerdaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERDA_INSUMOS_JURIDICA");

            entity.HasOne(d => d.SubCodigoNavigation).WithMany(p => p.PerdaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERDA_INSUMOS_SUBSTANCIA");

            entity.HasOne(d => d.TmpCodigoNavigation).WithMany(p => p.PerdaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERDA_INSUMOS_TIPO_MOTIVO_PERDA");

            entity.HasOne(d => d.TuiCodigoNavigation).WithMany(p => p.PerdaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERDA_INSUMOS_TIPO_UNIDADE_INSUMO");
        });

        modelBuilder.Entity<PerdaProduto>(entity =>
        {
            entity.HasKey(e => e.PprCodigo).HasName("PERDAS_PRODUTOS_PK");

            entity.Property(e => e.PprCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.PerdaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERDA_PRODUTOS_PRODUTO");

            entity.HasOne(d => d.TmpCodigoNavigation).WithMany(p => p.PerdaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PERDA_PRODUTOS_TIPO_MOTIVO_PERDA");
        });

        modelBuilder.Entity<Perfil>(entity =>
        {
            entity.Property(e => e.PerCodigo).ValueGeneratedNever();
            entity.Property(e => e.PerLiberado).IsFixedLength();
        });

        modelBuilder.Entity<Periodicidade>(entity =>
        {
            entity.HasKey(e => e.PdeCodigo).HasName("Periodicidade_PK");

            entity.Property(e => e.PdeCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.PesCodigo).HasName("Pessoa_PK");

            entity.ToTable("PESSOA", tb =>
                {
                    tb.HasTrigger("PESSOA_DeletionTrigger");
                    tb.HasTrigger("PESSOA_InsertTrigger");
                    tb.HasTrigger("PESSOA_UpdateTrigger");
                });

            entity.Property(e => e.PesCodigo).ValueGeneratedNever();
            entity.Property(e => e.CreationDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.LastEditDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.PesBloqueado).HasDefaultValueSql("('N')");
            entity.Property(e => e.PesCobrancaJuros).HasDefaultValueSql("((0))");
            entity.Property(e => e.PesDataExclusao).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.PesDiaCobranca).IsFixedLength();
            entity.Property(e => e.PesDtaCadastro).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.PesDtaUltimaCompra).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.PesLimiteCredito).HasDefaultValueSql("((0))");
            entity.Property(e => e.PesPctDesconto).HasDefaultValueSql("((0))");
            entity.Property(e => e.PesPctJuros).HasDefaultValueSql("((0))");
            entity.Property(e => e.PesTipoCadastro).IsFixedLength();
            entity.Property(e => e.PesTipoCobranca).IsFixedLength();
            entity.Property(e => e.PesTipoPessoa).IsFixedLength();

            entity.HasOne(d => d.CvnCodigoNavigation).WithMany(p => p.Pessoas).HasConstraintName("CONVENIO_PESSOA_FK1");

            entity.HasOne(d => d.IndIedestCodigoNavigation).WithMany(p => p.Pessoas).HasConstraintName("FK_PESSOA_NFe_TIPO_CONTRIBUINTE");
        });

        modelBuilder.Entity<PessoaClassificacao>(entity =>
        {
            entity.Property(e => e.PclasCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ClaCodigoNavigation).WithMany(p => p.PessoaClassificacaos).HasConstraintName("FK_PESSOA_CLASSIFICACAO_CLASSIFICACAO");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.PessoaClassificacaos).HasConstraintName("FK_PESSOA_CLASSIFICACAO_PESSOA");
        });

        modelBuilder.Entity<PessoaTombstone>(entity =>
        {
            entity.HasKey(e => e.PesCodigo).HasName("PKDEL_PESSOA_Tombstone_PES_Codigo");

            entity.Property(e => e.PesCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetAgendum>(entity =>
        {
            entity.Property(e => e.AgeCodigo).ValueGeneratedNever();
            entity.Property(e => e.AgeDataExecucao).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.AgeDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.PacCodigoNavigation).WithMany(p => p.PetAgenda).HasConstraintName("FK_PET_AGENDA_PET_PACIENTE");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.PetAgenda).HasConstraintName("FK_PET_AGENDA_PESSOA");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.PetAgenda).HasConstraintName("FK_PET_AGENDA_PRODUTO");
        });

        modelBuilder.Entity<PetConsultaItemNaoUsar>(entity =>
        {
            entity.HasKey(e => e.CitCodigo).HasName("PK_PET_CONSULTA_ITEM");

            entity.Property(e => e.CitCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetConsultaServicoNaoUsar>(entity =>
        {
            entity.HasKey(e => e.CseCodigo).HasName("PK_PET_CONSULTA_SERVICO");

            entity.Property(e => e.CseCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetConsultum>(entity =>
        {
            entity.Property(e => e.ConCodigo).ValueGeneratedNever();
            entity.Property(e => e.ConDataFechamento).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.PacCodigoNavigation).WithMany(p => p.PetConsulta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PET_CONSULTA_PET_PACIENTE");
        });

        modelBuilder.Entity<PetEspecie>(entity =>
        {
            entity.Property(e => e.EspCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetFichaReceituario>(entity =>
        {
            entity.HasKey(e => e.RecCodigo).HasName("PK_PET_RECEITUARIO");

            entity.Property(e => e.RecCodigo).ValueGeneratedNever();
            entity.Property(e => e.RecDataRetorno).HasDefaultValueSql("(((1)/(1))/(1900))");
        });

        modelBuilder.Entity<PetPaciente>(entity =>
        {
            entity.Property(e => e.PacCodigo).ValueGeneratedNever();
            entity.Property(e => e.PacDataExclusao).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.PacSexo).IsFixedLength();
        });

        modelBuilder.Entity<PetPelagem>(entity =>
        {
            entity.Property(e => e.PelCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetRaca>(entity =>
        {
            entity.Property(e => e.RacCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EspCodigoNavigation).WithMany(p => p.PetRacas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PET_RACA_PET_ESPECIE");
        });

        modelBuilder.Entity<PetServicoNaoUsarmai>(entity =>
        {
            entity.HasKey(e => e.SerCodigo).HasName("PK_PET_Servico");

            entity.Property(e => e.SerCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetTipoRetornoVacina>(entity =>
        {
            entity.Property(e => e.TrvCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<PetVacina>(entity =>
        {
            entity.Property(e => e.VacCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.TrvCodigoNavigation).WithMany(p => p.PetVacinas).HasConstraintName("FK_PET_VACINA_PET_TIPO_RETORNO_VACINA");
        });

        modelBuilder.Entity<PetVacinacao>(entity =>
        {
            entity.Property(e => e.VcoCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.PacCodigoNavigation).WithMany(p => p.PetVacinacaos).HasConstraintName("FK_PET_VACINACAO_PET_PACIENTE");

            entity.HasOne(d => d.VacCodigoNavigation).WithMany(p => p.PetVacinacaos).HasConstraintName("FK_PET_VACINACAO_PET_VACINA");
        });

        modelBuilder.Entity<PlanoConta>(entity =>
        {
            entity.Property(e => e.PctCodigoReduzido).ValueGeneratedNever();
            entity.Property(e => e.PctConta).IsFixedLength();
            entity.Property(e => e.PctContaSistema)
                .HasDefaultValueSql("('N')")
                .IsFixedLength();
            entity.Property(e => e.PctSensibilizaCaixa).IsFixedLength();
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.ProCodigo).HasName("PK__PRODUTO__108B795B");

            entity.Property(e => e.ProCodigo).ValueGeneratedNever();
            entity.Property(e => e.ProBalcao)
                .HasDefaultValueSql("((1))")
                .IsFixedLength();
            entity.Property(e => e.ProDataAlteracao).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDataCadastro).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDataDesativo).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDataExclusao).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDescAprazoAtivo)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.ProDescAvistaAtivo)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.ProDtaFinalDescAprazo).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDtaFinalDescAvista).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDtaInicioDescAprazo).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProDtaInicioDescAvista).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.ProEstoqueAtual).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProEstoqueMinimo).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProFracao).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProOrigemIcms).IsFixedLength();
            entity.Property(e => e.ProPctComissaoPrazo).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProPctComissaoVista).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProPctDescAprazo).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProPctDescAvista).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProPctLucro).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProPsi).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProPsicotropico).IsFixedLength();
            entity.Property(e => e.ProTipoItem)
                .HasDefaultValueSql("((0))")
                .IsFixedLength();
            entity.Property(e => e.ProUsoContinuo).IsFixedLength();
            entity.Property(e => e.ProVlrCustoFabrica).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProVlrCustoMedio).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProVlrCustoReal).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProVlrVenda).HasDefaultValueSql("((0))");
            entity.Property(e => e.ProVrlCustoMedioReal).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.BulCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("BULARIO_PRODUTO_FK1");

            entity.HasOne(d => d.CatCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("CATEGORIA_PRODUTO_FK1");

            entity.HasOne(d => d.ClaCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("CLASSIFICACAO_PRODUTO_FK1");

            entity.HasOne(d => d.ClatCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("FK_PRODUTO_CLASSE_TERAPEUTICA");

            entity.HasOne(d => d.ClatmedCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("FK_PRODUTO_CLASSIFICACAO_TIPO_MEDICAMENTO");

            entity.HasOne(d => d.FabCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("FABRICANTE_PRODUTO_FK1");

            entity.HasOne(d => d.LinCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("LINHA_PRODUTO_PRODUTO_FK1");

            entity.HasOne(d => d.TipCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("FK_PRODUTO_TIPO_PRODUTO");

            entity.HasOne(d => d.TrbCodigoNavigation).WithMany(p => p.Produtos).HasConstraintName("TRIBUTACAO_PRODUTO_FK1");
        });

        modelBuilder.Entity<ProdutoInventario>(entity =>
        {
            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.ProdutoInventarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUTO_INVENTARIO_PRODUTO");
        });

        modelBuilder.Entity<ProdutoNf>(entity =>
        {
            entity.HasOne(d => d.ProCodigoNavigation).WithMany().HasConstraintName("produto_fk");
        });

        modelBuilder.Entity<PsicoCliente>(entity =>
        {
            entity.Property(e => e.PcliCodigo).ValueGeneratedNever();
            entity.Property(e => e.PcliDataCadastro).HasDefaultValueSql("(((1)/(1))/(1900))");
        });

        modelBuilder.Entity<PsicoConfiguraco>(entity =>
        {
            entity.Property(e => e.PsiCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<RegistroEcf>(entity =>
        {
            entity.HasKey(e => e.RegCodigo).HasName("PK_REGISTRO_ECF_1");

            entity.Property(e => e.RegCodigo).ValueGeneratedNever();
            entity.Property(e => e.ImpMfadicional).IsFixedLength();
            entity.Property(e => e.ImpModeloEcf).IsFixedLength();
            entity.Property(e => e.ImpTipoEcf).IsFixedLength();
            entity.Property(e => e.ImpVersaoSb).IsFixedLength();

            entity.HasOne(d => d.ImpCodigoNavigation).WithMany(p => p.RegistroEcfs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_REGISTRO_ECF_IMPRESSORA");
        });

        modelBuilder.Entity<ReplicacoesPendente>(entity =>
        {
            entity.HasKey(e => e.PenCodigo).HasName("pk_PEN_CODIGO");

            entity.Property(e => e.PenCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<ResponsavelTecnico>(entity =>
        {
            entity.Property(e => e.RteCpf).ValueGeneratedNever();
            entity.Property(e => e.RteCrfestado).IsFixedLength();
        });

        modelBuilder.Entity<RestbarEnderecoEntrega>(entity =>
        {
            entity.Property(e => e.RbeCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<RestbarPedido>(entity =>
        {
            entity.Property(e => e.RbpCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<RestbarPedidoProduto>(entity =>
        {
            entity.Property(e => e.RbppCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<RestbarTipo>(entity =>
        {
            entity.Property(e => e.RbtCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SaidaInsumo>(entity =>
        {
            entity.HasKey(e => e.SinCodigo).HasName("PK_SAIDA_INSUMOS_1");

            entity.Property(e => e.SinCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.CliCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_FISICA");

            entity.HasOne(d => d.ForCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_JURIDICA");

            entity.HasOne(d => d.MedCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_MEDICOS");

            entity.HasOne(d => d.SubCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_SUBSTANCIA");

            entity.HasOne(d => d.TdoCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_TIPO_DOCUMENTOS");

            entity.HasOne(d => d.TioCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_TIPO_RECEITUARIO");

            entity.HasOne(d => d.TufCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_TIPO_UNIDADE_FARMACOTECNICA");

            entity.HasOne(d => d.TuiCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_TIPO_UNIDADE_INSUMO");

            entity.HasOne(d => d.TumCodigoNavigation).WithMany(p => p.SaidaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_INSUMOS_TIPO_USO_MEDICAMENTO");
        });

        modelBuilder.Entity<SaidaProduto>(entity =>
        {
            entity.HasKey(e => e.SprCodigo).HasName("SAIDA_PRODUTOS_PK");

            entity.Property(e => e.SprCodigo).ValueGeneratedNever();
            entity.Property(e => e.SprUsoProlongado).IsFixedLength();

            entity.HasOne(d => d.MedCodigoNavigation).WithMany(p => p.SaidaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_PRODUTOS_MEDICOS");

            entity.HasOne(d => d.PcliCodigoNavigation).WithMany(p => p.SaidaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_PRODUTOS_PSICO_CLIENTE");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.SaidaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_PRODUTOS_PRODUTO");

            entity.HasOne(d => d.TdoCodigoNavigation).WithMany(p => p.SaidaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_PRODUTOS_TIPO_DOCUMENTOS");

            entity.HasOne(d => d.TioCodigoNavigation).WithMany(p => p.SaidaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_PRODUTOS_TIPO_RECEITUARIO");

            entity.HasOne(d => d.TumCodigoNavigation).WithMany(p => p.SaidaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SAIDA_PRODUTOS_TIPO_USO_MEDICAMENTO");
        });

        modelBuilder.Entity<SerCarro>(entity =>
        {
            entity.Property(e => e.CarCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.MonCodigoNavigation).WithMany(p => p.SerCarros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SER_CARRO_SER_MONTADORA");
        });

        modelBuilder.Entity<SerCompra>(entity =>
        {
            entity.Property(e => e.ComCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ForCodigoNavigation).WithMany(p => p.SerCompras).HasConstraintName("FK_SER_COMPRA_FORNECEDORES");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.SerCompras).HasConstraintName("FK_SER_COMPRA_PESSOA");

            entity.HasOne(d => d.UsrCodigoNavigation).WithMany(p => p.SerCompras).HasConstraintName("FK_SER_COMPRA_USUARIO");
        });

        modelBuilder.Entity<SerCompraItem>(entity =>
        {
            entity.Property(e => e.CoiCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ComCodigoNavigation).WithMany(p => p.SerCompraItems).HasConstraintName("FK_SER_COMPRA_ITEM_SER_COMPRA");

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.SerCompraItems).HasConstraintName("FK_SER_COMPRA_ITEM_PRODUTO");
        });

        modelBuilder.Entity<SerCor>(entity =>
        {
            entity.Property(e => e.CorCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerEquipamento>(entity =>
        {
            entity.Property(e => e.EquiCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.CorCodigoNavigation).WithMany(p => p.SerEquipamentos).HasConstraintName("FK_SER_EQUIPAMENTO_SER_COR");

            entity.HasOne(d => d.EquinomCodigoNavigation).WithMany(p => p.SerEquipamentos).HasConstraintName("FK_SER_EQUIPAMENTO_SER_EQUIPAMENTO_NOME");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.SerEquipamentos).HasConstraintName("FK_SER_EQUIPAMENTO_PESSOA");
        });

        modelBuilder.Entity<SerEquipamentoModelo>(entity =>
        {
            entity.Property(e => e.EquimodCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerEquipamentoNome>(entity =>
        {
            entity.Property(e => e.EquinomCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EquimodCodigoNavigation).WithMany(p => p.SerEquipamentoNomes).HasConstraintName("FK_SER_EQUIPAMENTO_NOME_SER_EQUIPAMENTO_MODELO");
        });

        modelBuilder.Entity<SerEquipamentoServico>(entity =>
        {
            entity.Property(e => e.EquiserCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.EquiCodigoNavigation).WithMany(p => p.SerEquipamentoServicos).HasConstraintName("FK_SER_EQUIPAMENTO_SERVICO_SER_EQUIPAMENTO");

            entity.HasOne(d => d.SerCodigoNavigation).WithMany(p => p.SerEquipamentoServicos).HasConstraintName("FK_SER_EQUIPAMENTO_SERVICO_SER_SERVICO");
        });

        modelBuilder.Entity<SerFuncionario>(entity =>
        {
            entity.HasKey(e => e.FunCodigo).HasName("SER_FUNCIONARIO_PK");

            entity.Property(e => e.FunCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerMontadora>(entity =>
        {
            entity.HasKey(e => e.MonCodigo).HasName("SER_MONTADORA_PK");

            entity.Property(e => e.MonCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerParte>(entity =>
        {
            entity.HasKey(e => e.ParCodigo).HasName("SER_PARTE_PK");

            entity.Property(e => e.ParCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerServico>(entity =>
        {
            entity.HasKey(e => e.SerCodigo).HasName("SER_SERVICO_PK");

            entity.Property(e => e.SerCodigo).ValueGeneratedNever();
            entity.Property(e => e.SerDataFaturado).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.SerDataInativo).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.EquiCodigoNavigation).WithMany(p => p.SerServicos).HasConstraintName("FK_SER_SERVICO_SER_EQUIPAMENTO");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.SerServicos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SER_SERVICO_PESSOA");

            entity.HasOne(d => d.StaCodigoNavigation).WithMany(p => p.SerServicos).HasConstraintName("FK_SER_SERVICO_SER_STATUS");

            entity.HasOne(d => d.TseCodigoNavigation).WithMany(p => p.SerServicos).HasConstraintName("FK_SER_SERVICO_SER_TIPO_SERVICO");

            entity.HasOne(d => d.UsrCodigoNavigation).WithMany(p => p.SerServicos).HasConstraintName("FK_SER_SERVICO_USUARIO");

            entity.HasOne(d => d.VeiCodigoNavigation).WithMany(p => p.SerServicos).HasConstraintName("SER_VEICULO_SER_SERVICO_FK1");
        });

        modelBuilder.Entity<SerServicoParte>(entity =>
        {
            entity.Property(e => e.SerparCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ParCodigoNavigation).WithMany(p => p.SerServicoPartes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SER_SERVICO_PARTE_SER_PARTE");

            entity.HasOne(d => d.SerCodigoNavigation).WithMany(p => p.SerServicoPartes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SER_SERVICO_PARTE_SER_SERVICO");
        });

        modelBuilder.Entity<SerServicoParteTecnico>(entity =>
        {
            entity.Property(e => e.SerpartecCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.SerparCodigoNavigation).WithMany(p => p.SerServicoParteTecnicos).HasConstraintName("FK_SER_SERVICO_PARTE_TECNICO_SER_SERVICO_PARTE");

            entity.HasOne(d => d.UsrCodigoNavigation).WithMany(p => p.SerServicoParteTecnicos).HasConstraintName("FK_SER_SERVICO_PARTE_TECNICO_USUARIO");
        });

        modelBuilder.Entity<SerStatus>(entity =>
        {
            entity.Property(e => e.StaCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerTipoServico>(entity =>
        {
            entity.Property(e => e.TseCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<SerVeiculo>(entity =>
        {
            entity.HasKey(e => e.VeiCodigo).HasName("SER_VEICULO_PK");

            entity.Property(e => e.VeiCodigo).ValueGeneratedNever();
            entity.Property(e => e.VeiDataExclusao).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.CarCodigoNavigation).WithMany(p => p.SerVeiculos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SER_VEICULO_SER_CARRO");

            entity.HasOne(d => d.CorCodigoNavigation).WithMany(p => p.SerVeiculos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SER_VEICULO_SER_COR");
        });

        modelBuilder.Entity<SubstanciaProduto>(entity =>
        {
            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.SubstanciaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SUBSTANCIA_PRODUTO_PRODUTO");
        });

        modelBuilder.Entity<Substancium>(entity =>
        {
            entity.HasKey(e => e.SubCodigo).HasName("SUBSTANCIA_PK");

            entity.Property(e => e.SubCodigo).ValueGeneratedNever();
            entity.Property(e => e.NumConcent).IsFixedLength();
            entity.Property(e => e.SubDataInclusao).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.SubDcb).IsFixedLength();

            entity.HasOne(d => d.GrpCodigoNavigation).WithMany(p => p.Substancia).HasConstraintName("FK_SUBSTANCIA_GRUPO");

            entity.HasOne(d => d.TioCodigoNavigation).WithMany(p => p.Substancia).HasConstraintName("FK_SUBSTANCIA_TIPO_RECEITUARIO");
        });

        modelBuilder.Entity<Teste>(entity =>
        {
            entity.ToView("teste");
        });

        modelBuilder.Entity<TipoDocumento>(entity =>
        {
            entity.Property(e => e.TdoCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoMotivoPerdum>(entity =>
        {
            entity.Property(e => e.TmpCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoNotafiscal>(entity =>
        {
            entity.Property(e => e.TnfCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoProduto>(entity =>
        {
            entity.Property(e => e.TipCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoReceituario>(entity =>
        {
            entity.Property(e => e.TioCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoUnidadeFarmacotecnica>(entity =>
        {
            entity.Property(e => e.TufCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoUnidadeInsumo>(entity =>
        {
            entity.Property(e => e.TuiCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoUsoMedicamento>(entity =>
        {
            entity.Property(e => e.TumCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TipoVendum>(entity =>
        {
            entity.Property(e => e.TpvCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<TransferenciaInsumo>(entity =>
        {
            entity.Property(e => e.TinCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ForCodigoInsumoNavigation).WithMany(p => p.TransferenciaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFERENCIA_INSUMOS_JURIDICA");

            entity.HasOne(d => d.SubCodigoNavigation).WithMany(p => p.TransferenciaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFERENCIA_INSUMOS_SUBSTANCIA");

            entity.HasOne(d => d.TnfCodigoNavigation).WithMany(p => p.TransferenciaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFERENCIA_INSUMOS_TIPO_NOTAFISCAL");

            entity.HasOne(d => d.TuiCodigoNavigation).WithMany(p => p.TransferenciaInsumos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFERENCIA_INSUMOS_TIPO_UNIDADE_INSUMO");
        });

        modelBuilder.Entity<TransferenciaProduto>(entity =>
        {
            entity.HasKey(e => e.TprCodigo).HasName("TRANSFERENCIA_PRODUTOS_PK");

            entity.Property(e => e.TprCodigo).ValueGeneratedNever();

            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.TransferenciaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFERENCIA_PRODUTOS_PRODUTO");

            entity.HasOne(d => d.TnfCodigoNavigation).WithMany(p => p.TransferenciaProdutos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRANSFERENCIA_PRODUTOS_TIPO_NOTAFISCAL");
        });

        modelBuilder.Entity<Transportadora>(entity =>
        {
            entity.Property(e => e.TraCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Tributacao>(entity =>
        {
            entity.HasKey(e => e.TrbCodigo).HasName("Tributacao_PK");

            entity.Property(e => e.TrbCodigo).ValueGeneratedNever();
            entity.Property(e => e.TrbPctAliquota).HasDefaultValueSql("('0')");
        });

        modelBuilder.Entity<UnidadeMedidum>(entity =>
        {
            entity.Property(e => e.UniCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsrCodigo).HasName("USUARIO_PK");

            entity.Property(e => e.UsrCodigo).ValueGeneratedNever();
            entity.Property(e => e.UsrNivelAcesso).IsFixedLength();
            entity.Property(e => e.UsrStatus).IsFixedLength();

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.Usuarios)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_USUARIO_PESSOA");
        });

        modelBuilder.Entity<V1>(entity =>
        {
            entity.ToView("v1");
        });

        modelBuilder.Entity<VBmpo>(entity =>
        {
            entity.ToView("vBMPO");

            entity.Property(e => e.SubDcb).IsFixedLength();
        });

        modelBuilder.Entity<VendaLote>(entity =>
        {
            entity.HasOne(d => d.ProCodigoNavigation).WithMany(p => p.VendaLotes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENDA_LOTE_PRODUTO");
        });

        modelBuilder.Entity<VendaOrigem>(entity =>
        {
            entity.Property(e => e.VorCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<VendaPagamento>(entity =>
        {
            entity.Property(e => e.VpgCodigo).ValueGeneratedNever();
            entity.Property(e => e.VpgDataVencimento).HasDefaultValueSql("(((1)/(1))/(1900))");

            entity.HasOne(d => d.VdaCodigoNavigation).WithMany(p => p.VendaPagamentos).HasConstraintName("FK_VENDA_PAGAMENTO_VENDA");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.Property(e => e.VenCodigo).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vendum>(entity =>
        {
            entity.HasKey(e => e.VdaCodigo).HasName("CAIXA_MOVIMENTO_PK");

            entity.Property(e => e.VdaCodigo).ValueGeneratedNever();
            entity.Property(e => e.VdaControlaEntrega).IsFixedLength();
            entity.Property(e => e.VdaDataEstorno).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.VdaDataLancamento).HasDefaultValueSql("(((1)/(1))/(1900))");
            entity.Property(e => e.VdaDescontoTotal).HasDefaultValueSql("((0))");
            entity.Property(e => e.VdaNumeroEcf).HasDefaultValueSql("((0))");
            entity.Property(e => e.VdaParcelas).HasDefaultValueSql("((0))");
            entity.Property(e => e.VdaSituacaoEnvio).IsFixedLength();
            entity.Property(e => e.VdaStatus).IsFixedLength();
            entity.Property(e => e.VdaValor).HasDefaultValueSql("((0))");
            entity.Property(e => e.VdaValorDevolvido).HasDefaultValueSql("((0))");

            entity.HasOne(d => d.OrcCodigoNavigation).WithMany(p => p.Venda).HasConstraintName("Orcamento_fk");

            entity.HasOne(d => d.PesCodigoNavigation).WithMany(p => p.Venda)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VENDA_PESSOA");

            entity.HasOne(d => d.SerCodigoNavigation).WithMany(p => p.Venda).HasConstraintName("FK_VENDA_SER_SERVICO");

            entity.HasOne(d => d.TpvCodigoNavigation).WithMany(p => p.Venda).HasConstraintName("FK_VENDA_TIPO_VENDA");

            entity.HasOne(d => d.UsrUsuarioSistemaNavigation).WithMany(p => p.Venda).HasConstraintName("FK_VENDA_USUARIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
