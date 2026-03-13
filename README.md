# AspireK8sBooleanEnvRepro

Minimal repro for an Aspire Kubernetes publish failure when a non-string environment value is present.

## Repro

```powershell
aspire publish --apphost .\Repro.AppHost\Repro.AppHost.csproj -o .\k8s-artifacts --non-interactive
```

## Expected error

`System.NotSupportedException: Unsupported value type: Boolean`

Stack includes:

- `Aspire.Hosting.Kubernetes.KubernetesResource.ProcessValueAsync`
- `Aspire.Hosting.Kubernetes.KubernetesResource.ProcessEnvironmentAsync`
