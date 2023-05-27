# ABP.IO Audit Reader (Application Module)

Expose Out-of-the-box services to access auditing entities.

You simple need to install this package and reference it from your Application and Host projects:

- Then add the module depency on your ApplicationModuleClass like this:

```cs
...
DependsOn(typeof(AuditApplicationModule
...
public class YourApplicationModule : AbpModule
```

- Finally go to your HostModule and add the module to the ConventionalControllers:

```cs
private void ConfigureConventionalControllers()
    {
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(YourApplicationModule).Assembly);
            options.ConventionalControllers.Create(typeof(AuditApplicationModule).Assembly);
        });
    }
```
