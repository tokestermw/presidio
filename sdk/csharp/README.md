# Microsoft.Presidio - ASP.NET Core 2.0 Server

Context aware, pluggable and customizable PII anonymization service for text and images.

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/Microsoft.Presidio
docker build -t microsoft.presidio .
docker run -p 5000:5000 microsoft.presidio
```
