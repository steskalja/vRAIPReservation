# vRAIPRes
 This is a tool for vRA IPAM IP Address reservations. It is a winforms based gui tool.
 
 To use the tool you need to have read/write access to the vRA mssql database
 
 You need to modify the vRAIPRes.exe.config file. 
 
 You will need to set your Data Source, Initial Catalog, and security features.
 
 For example
 
 vRAIPRes.exe.config:
 
 With integrated security:
 

<connectionStrings>
 <add name="vRAIPRes.Properties.Settings.vra_prodConnectionString"
     connectionString="Data Source=<SQL Instance>;Initial Catalog=<VRA__DB>;Integrated Security=True;TrustServerCertificate=True"
     providerName="System.Data.SqlClient" />
</connectionStrings>
    
 
 With username/password


<connectionStrings>
 <add name="vRAIPRes.Properties.Settings.vra_prodConnectionString"
            connectionString="Data Source=<SQL Instance>;Initial Catalog=<VRA__DB>;User Id=myUsername;
Password=myPassword;TrustServerCertificate=True"
            providerName="System.Data.SqlClient" />
</connectionStrings>
 
