![telegrama (3)](https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/60712f4f-09fd-48cc-8920-e272b767fc0b)
# CrackFunciones

![Screenshot 2023-06-22 14-40-46](https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/4fe95f77-2267-48e9-8281-fe4c3143d183)

El proyecto fue creado con el fin de facilitarle el trabajo a las personas que recién inician el cracking y checkers (programación).

## Cómo funciona
Pasos:
- Primero debes descargar el proyecto tal y como está. En cada carpeta se encuentran bibliotecas de clases que usaremos más adelante.
- Luego, desde nuestro proyecto, hacemos referencia a las bibliotecas de clases que se encuentran dentro de cada carpeta.
- ¡Listo! Ahora tendremos las bibliotecas de clases que nos ayudarán más adelante a programar.

El proyecto `example` es un ejemplo para que puedas ver más o menos cómo funciona.

## Request de código

Headers:

```csharp
Dictionary<string, string> headers = new Dictionary<string, string>()
{
    { "Origin", "https://streamable.com" },
    { "Pragma", "no-cache" },
    { "Referer", "https://streamable.com/" },
    { "Sec-Ch-Ua", "\"Not.A/Brand\";v=\"8\", \"Chromium\";v=\"114\", \"Google Chrome\";v=\"114\"" },
    { "Sec-Ch-Ua-Mobile", "?0" },
    { "Sec-Ch-Ua-Platform", "\"Windows\"" },
    { "Sec-Fetch-Dest", "empty" },
    { "Sec-Fetch-Mode", "cors" },
    { "Sec-Fetch-Site", "same-site" },
    { "User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36" }
};
```

Esto se basa en un ejemplo cada vez que vayamos a usar headers, recuerda usar Dictionary y agregarle los datos manualmente, de lo contrario generará errores en el código y no funcionará.

Request:
```csharp
var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "POST", "{\"username\":\"<USER>\",\"password\":\"<PASS>\"}",
                    "application/json", headers, array[0], array[1], ProxyType.Socks4, list[rn.Next(list.Count)]).Content;
```
            
**Esto se basa en enviar la petición ya programada a la biblioteca de clases. El orden es el siguiente: (url), (method), (content), (contentype), (header) -> Recuerda agregar los headers en un Dictionary, (email), (password), (ProxyType.Socks4, ProxyType.HTTP, ProxyType.Socks5, ProxyType.NO) -> Cualquier tipo de proxy que queramos usar, (proxy) -> aquí se ingresará el proxy.**

Nota: El código solo soporta los métodos POST y GET.

Si vamos a hacer una petición GET, sería así:

```csharp
var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "GET", string.Empty,
                   string.Empty, null, string.Empty, string.Empty, ProxyType.No, string.Empty).Content;
```
**Cada vez que no vayamos a usar datos, simplemente usemos "String.Empty" o, si es un Dictionary, nulo.**

Si queremos obtener datos como el contenido (Content) o el código de estado (Status Code), podría ser así:


```csharp
var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "GET", string.Empty,
                   string.Empty, null, string.Empty, string.Empty, ProxyType.No, string.Empty);
string content = Recived.Content;
int code = (int)Recived.StatusCode;
```
Estas son algunas formas en las que podemos usarlo.




## PARSE de código


LR:

```csharp
var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "POST", "{\"username\":\"<USER>\",\"password\":\"<PASS>\"}",
                "application/json", headers, array[0], array[1], ProxyType.Socks4, list[rn.Next(list.Count)]).Content;
                string texts = Parse.LR(Recived.ToString(), "{\"error\":\"", "\",\"message\":", false);
```


Method LR:
- Muestro un ejemplo como usarlo arriva para que lo analisen.
- El primer parametro que recive es el dato que que responde nuestra solicitud POST, por segundo donde va a comensar a capturar y el tercero en donde terminara.
- El `FALSE` que vemos ahi para `Recursividad` Si recursive es true, se realiza la recursividad para capturar datos repetidos.


JSON:

```csharp
var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "POST", "{\"username\":\"<USER>\",\"password\":\"<PASS>\"}",
                "application/json", headers, array[0], array[1], ProxyType.Socks4, list[rn.Next(list.Count)]).Content;
                string texts = Parse.JSON(Recived.ToString(), "message").FirstOrDefault<string>();
```
Method JSON:
- Muestro un ejemplo como usarlo arriva para que lo analisen.



## Funcioens de código

![Screenshot 2023-06-22 15-45-51](https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/557acf65-8552-4e48-aa71-3cebca484054)


Y la ultima parte hablemos de las funciones. 

Funciones:
- Encriptaciones
- Ramdons
- Times
- Otros

**Ustedes pueden buscarlas y listo**
![telegrama (3)](https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/b656bcde-37ef-477d-94ba-091c414b3c08)


# Creador
![Screenshot 2023-06-22 15-33-34](https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/129fdb61-07da-4d88-b839-902e6e3c90be)

<img src="https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/b656bcde-37ef-477d-94ba-091c414b3c08" alt="Telegram" width="20"/> Contacto: &#64;CrackerVntt
