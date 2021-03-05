using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace API_CarCenter.Models
{
    public partial class CarCenterContext : DbContext
    {
        public CarCenterContext()
        {
        }

        public CarCenterContext(DbContextOptions<CarCenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbCiudad> TbCiudads { get; set; }
        public virtual DbSet<TbEstadoMo> TbEstadoMos { get; set; }
        public virtual DbSet<TbPersonal> TbPersonals { get; set; }
        public virtual DbSet<TbProducto> TbProductos { get; set; }
        public virtual DbSet<TbTaller> TbTallers { get; set; }
        public virtual DbSet<TbTipoDocum> TbTipoDocums { get; set; }
        public virtual DbSet<TbTipoProd> TbTipoProds { get; set; }
        public virtual DbSet<ThCliente> ThClientes { get; set; }
        public virtual DbSet<ThFactCab> ThFactCabs { get; set; }
        public virtual DbSet<ThFactMo> ThFactMos { get; set; }
        public virtual DbSet<ThFactProd> ThFactProds { get; set; }
        public virtual DbSet<ThHistMo> ThHistMos { get; set; }
        public virtual DbSet<ThHistProd> ThHistProds { get; set; }
        public virtual DbSet<ThHistVehic> ThHistVehics { get; set; }
        public virtual DbSet<ThHistVehicfoto> ThHistVehicfotos { get; set; }
        public virtual DbSet<ThInventario> ThInventarios { get; set; }
        public virtual DbSet<ThVehiculo> ThVehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<TbCiudad>(entity =>
            {
                entity.HasKey(e => e.IdCiudad);

                entity.ToTable("TB_CIUDAD");

                entity.Property(e => e.IdCiudad).HasColumnName("Id_ciudad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbEstadoMo>(entity =>
            {
                entity.HasKey(e => e.IdEstadoMo);

                entity.ToTable("TB_ESTADO_MO");

                entity.Property(e => e.IdEstadoMo).HasColumnName("Id_estado_mo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbPersonal>(entity =>
            {
                entity.HasKey(e => e.IdPerso);

                entity.ToTable("TB_PERSONAL");

                entity.Property(e => e.IdPerso).HasColumnName("Id_perso");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocum).HasColumnName("Id_Tipo_docum");

                entity.Property(e => e.IdTipoProd).HasColumnName("Id_tipo_prod");

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocumento)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Num_documento");

                entity.Property(e => e.ValMaxHora)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_max_hora");

                entity.Property(e => e.ValMinHora)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_min_hora");

                entity.HasOne(d => d.IdTipoDocumNavigation)
                    .WithMany(p => p.TbPersonals)
                    .HasForeignKey(d => d.IdTipoDocum)
                    .HasConstraintName("TBPERSONAL_TBTIPODOCUM");

                entity.HasOne(d => d.IdTipoProdNavigation)
                    .WithMany(p => p.TbPersonals)
                    .HasForeignKey(d => d.IdTipoProd)
                    .HasConstraintName("TBPERSONAL_TBTIPOSERVICIO");
            });

            modelBuilder.Entity<TbProducto>(entity =>
            {
                entity.HasKey(e => e.IdProd);

                entity.ToTable("TB_PRODUCTO");

                entity.Property(e => e.IdProd).HasColumnName("Id_prod");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoProd).HasColumnName("Id_tipo_prod");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ValMax)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_max");

                entity.Property(e => e.ValMin)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_min");

                entity.HasOne(d => d.IdTipoProdNavigation)
                    .WithMany(p => p.TbProductos)
                    .HasForeignKey(d => d.IdTipoProd)
                    .HasConstraintName("TBPRODUCTO_TBTIPOPROD");
            });

            modelBuilder.Entity<TbTaller>(entity =>
            {
                entity.HasKey(e => e.IdTaller);

                entity.ToTable("TB_TALLER");

                entity.Property(e => e.IdTaller).HasColumnName("Id_taller");

                entity.Property(e => e.IdCiudad).HasColumnName("Id_ciudad");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCiudadNavigation)
                    .WithMany(p => p.TbTallers)
                    .HasForeignKey(d => d.IdCiudad)
                    .HasConstraintName("TBTALLER_TBCIUDAD");
            });

            modelBuilder.Entity<TbTipoDocum>(entity =>
            {
                entity.HasKey(e => e.IdTipoDocum);

                entity.ToTable("TB_TIPO_DOCUM");

                entity.Property(e => e.IdTipoDocum)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_tipo_docum");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbTipoProd>(entity =>
            {
                entity.HasKey(e => e.IdTipoProd);

                entity.ToTable("TB_TIPO_PROD");

                entity.Property(e => e.IdTipoProd).HasColumnName("Id_tipo_prod");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.TipoProd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Tipo_prod");
            });

            modelBuilder.Entity<ThCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("TH_CLIENTE");

                entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdTipoDocum).HasColumnName("Id_tipo_docum");

                entity.Property(e => e.Nombre1)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre2)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.NumDocum)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("Num_docum");

                entity.Property(e => e.RazonSoc)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Razon_soc");

                entity.HasOne(d => d.IdTipoDocumNavigation)
                    .WithMany(p => p.ThClientes)
                    .HasForeignKey(d => d.IdTipoDocum)
                    .HasConstraintName("THCLIENTE_TBTIPODOCUM");
            });

            modelBuilder.Entity<ThFactCab>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.ToTable("TH_FACT_CAB");

                entity.Property(e => e.IdFactura).HasColumnName("Id_factura");

                entity.Property(e => e.FecFactura)
                    .HasColumnType("date")
                    .HasColumnName("Fec_factura");

                entity.Property(e => e.FecVencim)
                    .HasColumnType("date")
                    .HasColumnName("Fec_vencim");

                entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");

                entity.Property(e => e.IdHistVehic).HasColumnName("Id_hist_vehic");

                entity.Property(e => e.IdTaller).HasColumnName("Id_taller");

                entity.Property(e => e.PorIva)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorRetefte)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_retefte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorReteiva)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_reteiva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValBrutoMo)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_bruto_mo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValBrutoRep)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_bruto_rep")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValDesctoMo)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_descto_mo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValDesctoPrd)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_descto_prd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValIva)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValNeto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_neto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValNetoMo)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_neto_mo")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValNetoPrd)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_neto_prd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValRetefte)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_retefte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValReteiva)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_reteiva")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.ThFactCabs)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("THFACTCAB_THCLIENTE");

                entity.HasOne(d => d.IdHistVehicNavigation)
                    .WithMany(p => p.ThFactCabs)
                    .HasForeignKey(d => d.IdHistVehic)
                    .HasConstraintName("THFACTCAB_THHISTVEHIC");

                entity.HasOne(d => d.IdTallerNavigation)
                    .WithMany(p => p.ThFactCabs)
                    .HasForeignKey(d => d.IdTaller)
                    .HasConstraintName("THFACTCAB_TB_TALLER");
            });

            modelBuilder.Entity<ThFactMo>(entity =>
            {
                entity.HasKey(e => e.IdFactMo);

                entity.ToTable("TH_FACT_MO");

                entity.Property(e => e.IdFactMo).HasColumnName("Id_fact_mo");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFactura).HasColumnName("Id_factura");

                entity.Property(e => e.IdHistMo).HasColumnName("Id_hist_mo");

                entity.Property(e => e.PorIva)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorRetefte)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_retefte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorReteiva)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_reteiva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValBruto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_bruto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValDescto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_descto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValIva)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValNeto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_neto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValRetefte)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_retefte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValReteiva)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_reteiva")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.ThFactMos)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("THFACTMO_THFACTCAB");

                entity.HasOne(d => d.IdHistMoNavigation)
                    .WithMany(p => p.ThFactMos)
                    .HasForeignKey(d => d.IdHistMo)
                    .HasConstraintName("THFACTMO_THHISTMO");
            });

            modelBuilder.Entity<ThFactProd>(entity =>
            {
                entity.HasKey(e => e.IdFactProd);

                entity.ToTable("TH_FACT_PROD");

                entity.Property(e => e.IdFactProd).HasColumnName("Id_fact_prod");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdFactura).HasColumnName("Id_factura");

                entity.Property(e => e.IdHistProd).HasColumnName("Id_hist_prod");

                entity.Property(e => e.PorIva)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorRetefte)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_retefte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorReteiva)
                    .HasColumnType("numeric(10, 4)")
                    .HasColumnName("Por_reteiva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric(20, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValBruto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_bruto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValDescto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_descto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValIva)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_iva")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValNeto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_neto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValRetefte)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_retefte")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ValReteiva)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_reteiva")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.ThFactProds)
                    .HasForeignKey(d => d.IdFactura)
                    .HasConstraintName("THFACTREP_THFACTCAB");

                entity.HasOne(d => d.IdHistProdNavigation)
                    .WithMany(p => p.ThFactProds)
                    .HasForeignKey(d => d.IdHistProd)
                    .HasConstraintName("THFACTREP_THHISTREPU");
            });

            modelBuilder.Entity<ThHistMo>(entity =>
            {
                entity.HasKey(e => e.IdHistMo);

                entity.ToTable("TH_HIST_MO");

                entity.Property(e => e.IdHistMo).HasColumnName("Id_hist_mo");

                entity.Property(e => e.AutorizaDescto).HasColumnName("Autoriza_descto");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdHistVehic).HasColumnName("Id_hist_vehic");

                entity.Property(e => e.IdPerso).HasColumnName("Id_perso");

                entity.Property(e => e.PorDescto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Por_descto");

                entity.Property(e => e.PrecioAutoriz)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Precio_autoriz");

                entity.Property(e => e.ValDescto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_descto");

                entity.Property(e => e.ValMaxHora)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_max_hora");

                entity.Property(e => e.ValMinHora)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_min_hora");

                entity.HasOne(d => d.IdHistVehicNavigation)
                    .WithMany(p => p.ThHistMos)
                    .HasForeignKey(d => d.IdHistVehic)
                    .HasConstraintName("THHISTMO_THHISTVEHIC");

                entity.HasOne(d => d.IdPersoNavigation)
                    .WithMany(p => p.ThHistMos)
                    .HasForeignKey(d => d.IdPerso)
                    .HasConstraintName("THHISTMO_TBPERSONAL");
            });

            modelBuilder.Entity<ThHistProd>(entity =>
            {
                entity.HasKey(e => e.IdHistProd);

                entity.ToTable("TH_HIST_PROD");

                entity.Property(e => e.IdHistProd).HasColumnName("Id_hist_prod");

                entity.Property(e => e.AutorizaDescto).HasColumnName("Autoriza_descto");

                entity.Property(e => e.Cantidad).HasColumnType("numeric(20, 2)");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdHistVehic).HasColumnName("Id_hist_vehic");

                entity.Property(e => e.IdProd).HasColumnName("Id_prod");

                entity.Property(e => e.PorDescto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Por_descto");

                entity.Property(e => e.PrecioAutoriz)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Precio_autoriz");

                entity.Property(e => e.ValDescto)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_descto");

                entity.Property(e => e.ValMax)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_max");

                entity.Property(e => e.ValMin)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Val_min");

                entity.HasOne(d => d.IdProdNavigation)
                    .WithMany(p => p.ThHistProds)
                    .HasForeignKey(d => d.IdProd)
                    .HasConstraintName("THHISTPROD_TBPRODUCTO");
            });

            modelBuilder.Entity<ThHistVehic>(entity =>
            {
                entity.HasKey(e => e.IdHistVehic);

                entity.ToTable("TH_HIST_VEHIC");

                entity.Property(e => e.IdHistVehic).HasColumnName("Id_hist_vehic");

                entity.Property(e => e.DetalleEntrada)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Detalle_entrada");

                entity.Property(e => e.DetalleSalida)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Detalle_salida");

                entity.Property(e => e.DetalleValoracion)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("Detalle_valoracion");

                entity.Property(e => e.FecEntrada)
                    .HasColumnType("date")
                    .HasColumnName("Fec_entrada");

                entity.Property(e => e.FecSalida)
                    .HasColumnType("date")
                    .HasColumnName("Fec_salida");

                entity.Property(e => e.IdVehic).HasColumnName("Id_vehic");

                entity.Property(e => e.TecnicoValoracion).HasColumnName("Tecnico_valoracion");

                entity.HasOne(d => d.IdVehicNavigation)
                    .WithMany(p => p.ThHistVehics)
                    .HasForeignKey(d => d.IdVehic)
                    .HasConstraintName("THHISTVEHIC_THVEHICULO");
            });

            modelBuilder.Entity<ThHistVehicfoto>(entity =>
            {
                entity.HasKey(e => e.IdHistVehicfoto);

                entity.ToTable("TH_HIST_VEHICFOTO");

                entity.Property(e => e.IdHistVehicfoto).HasColumnName("Id_hist_vehicfoto");

                entity.Property(e => e.DetallesEntrada)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Detalles_entrada");

                entity.Property(e => e.DetallesSalida)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("Detalles_salida");

                entity.Property(e => e.FecEntrada)
                    .HasColumnType("date")
                    .HasColumnName("Fec_entrada");

                entity.Property(e => e.FecSalida)
                    .HasColumnType("date")
                    .HasColumnName("Fec_salida");

                entity.Property(e => e.IdHistVehic).HasColumnName("Id_hist_vehic");

                entity.Property(e => e.Imagen).IsRequired();

                entity.HasOne(d => d.IdHistVehicNavigation)
                    .WithMany(p => p.ThHistVehicfotos)
                    .HasForeignKey(d => d.IdHistVehic)
                    .HasConstraintName("THHISTFOTOVEHIC_THHISTVEHIC");
            });

            modelBuilder.Entity<ThInventario>(entity =>
            {
                entity.HasKey(e => e.IdInvent);

                entity.ToTable("TH_INVENTARIO");

                entity.Property(e => e.IdInvent).HasColumnName("Id_invent");

                entity.Property(e => e.CantEntra)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Cant_entra")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CantSale)
                    .HasColumnType("numeric(20, 2)")
                    .HasColumnName("Cant_sale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Detalle)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FecMvto)
                    .HasColumnType("date")
                    .HasColumnName("Fec_mvto");

                entity.Property(e => e.IdFactura).HasColumnName("Id_factura");

                entity.Property(e => e.IdProd).HasColumnName("Id_prod");

                entity.Property(e => e.IdTaller).HasColumnName("Id_taller");

                entity.HasOne(d => d.IdProdNavigation)
                    .WithMany(p => p.ThInventarios)
                    .HasForeignKey(d => d.IdProd)
                    .HasConstraintName("THINVENTARIO_TBPRODUCTO");

                entity.HasOne(d => d.IdTallerNavigation)
                    .WithMany(p => p.ThInventarios)
                    .HasForeignKey(d => d.IdTaller)
                    .HasConstraintName("THINVENTARIO_TBTALLER");
            });

            modelBuilder.Entity<ThVehiculo>(entity =>
            {
                entity.HasKey(e => e.IdVehic);

                entity.ToTable("TH_VEHICULO");

                entity.Property(e => e.IdVehic).HasColumnName("Id_vehic");

                entity.Property(e => e.Placa)
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
