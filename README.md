# CrackFunciones


![Screenshot 2023-06-22 14-40-46](https://github.com/CrackerVNTT/CrackFunciones/assets/137449559/4fe95f77-2267-48e9-8281-fe4c3143d183)

`El proyecto fue creado con el fin de facilitarle el trabajo a las personas que recien inician el cracking y checkers(programacio)`

## **Como Funciona?** ##
Pasos:
- Primero deves de descargar el proyecto tal y como esta, en cada carpeta se encuentran biblotecas de clases que usaremos adelante.
- Despues desde nuestro proyecto hacemos refenecia a las bibloteclas de clases que se encuentran dentro de cada carpeta.
- Y listo ya tendremos las biblitecas de clases que nos ayudaran mas adelante a programar

`El proyecto example va un ejemplo para que veas mas omenos como va la onda` 

## **Code Example** ##

Headers:
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
                
-Esto se basa en un ejemplo cada ves que nosotros vallamos a usar headers recuerden de usar Dictionary y agregarle los datos manuales, si no hacen eso generara errores el code y no funcionara.

Request:

var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "POST", "{\"username\":\"<USER>\",\"password\":\"<PASS>\"}",
                    "application/json", headers, array[0], array[1], ProxyType.Socks4, list[rn.Next(list.Count)]).Content;
-Esto se basa en enviar la peticion ya programada a la bibloteca de clase, este es el orden
(url), (method), (content), (contentype), (header)->Recuerden de agregar los headers en Dictionary, (email), (password), (ProxyType.Socks4, ProxyType.HTTP, ProxyType.Socks5, ProxyType.NO) -> Cualquier de ese tipo de proxys podemos usar (proxy) -> aqui se va a ingresar el proxy.

Nota:
-El code solo soporto Method POST y GET

Si van a hacer una peticion GET seria asi!
var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "GET", string.Empty,
                   string.Empty, null,string.Empty, string.Empty, ProxyType.No, string.Empty).Content;

-Cada ves que nosotros no vallamos a usar datos solo usemos "String.Empty" o si es Dictionary null.

Si queremos obtener datos como el Content o Status code Podria ser asi!

var Recived = Request.Request.SendRequest("https://ajax.streamable.com/check", "GET", string.Empty,
                   string.Empty, null,string.Empty, string.Empty, ProxyType.No, string.Empty);
string content = Recived.Content;
int code = (int)Recived.StatusCode;

-Son maneras en las que podemos usarlos.

