# Show Size

Mini App that shows file size.

```sh
./show_size test.txt 
85 bytes
```

AOT compile with:

```sh
dotnet publish -c Release -r linux-x64 /p:PublishAot=true --self-contained true
```