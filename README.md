# DemoWebApp

Basit bir .NET 9 web uygulaması - Azure DevOps pipeline testi için.

## Endpoints

- `GET /` - Ana sayfa, uygulama bilgileri
- `GET /health` - Sağlık kontrolü (health check)
- `GET /info` - Sunucu bilgileri

## Lokal Çalıştırma

```bash
dotnet restore
dotnet build
dotnet run
```

Tarayıcıda: `http://localhost:5000`

## Deployment

Bu proje Azure Pipelines ile otomatik olarak IIS'e deploy edilir.

### Pipeline Özellikleri:
- Otomatik build ve publish
- Pre-deployment validation
- Backup oluşturma
- Rollback desteği
- Health check kontrolü
- Log kayıtları

## Gereksinimler

- .NET 9 SDK
- IIS (deployment için)
- Windows Server (deployment için)
