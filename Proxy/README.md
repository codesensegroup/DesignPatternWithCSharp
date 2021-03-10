### 定義

> **代理模式(Proxy)**，為其他物件提供一種代理以控制對這個物件的存取。
>
> -- 大話設計模式 p.95

### 使用時機

> - 存取權利需要控制時。
> - 在存取時需要提供其他的功能時。

### 說優缺點

> **優點：**
>
> - 可以在 client 不知覺的狀況下操作 service object
> - 可以管理 service object 的 lifecycle (這些也是 client 不需要也通常不會去在乎的)
> - 即使 service object 還沒 ready 或是還不能 work， proxy 還是可以運作
> - 可以在不改動 client 與 service object 的前提下引進新的 proxy
>
> **缺點：**
>
> - code 的複雜度會提升
> - 從 service 回來的 response 可能會 delay (因為中間多經過一層 proxy)

### UML圖例

> ![image-20210310102730931](C:\Users\popo\AppData\Roaming\Typora\typora-user-images\image-20210310102730931.png)
>
> - Client 代表客戶端。
> - Subject是抽象主題。
> - RealSubjuct是真實的主題類別。
> - Proxy是代理類別。
> - **代理和真實的主題都實做相同的抽象主題類別，在代理中建立一個真實主題來作轉換。**
> - **跟 Adapter 的差別**：
>   - Adapter 是實作新的介面(與真實物件沒有關系)，是一種轉接成統一介面的概念。
>   - Proxy 是實作真實物件相同的介面，進行重新包裝(原有的SDK不足時加入檢查、流程)。
> - **跟 Decorator 的差別：**
>   - Decorator 是增加物件的行為。
>   - Proxy 是控制物件的存取。

### 實踐說明

> **對於真實物件的控制存取相關，都可以說是 Proxy Pattern 的變形。**
>
> - **防火牆代理人( Firewall)**：控制網路資源的存取，保護內部免於受到外面的侵害。常用於公司的防火牆系統
> - **備用代理人(Caching)**：將耗資源的運算結果暫存起來，供後續使用，以減少成本。常用於 Web Proxy。
> - **同步化代理人(Synchronization)**：提供安全的存取，讓多個執行緖存取同一個物件時不會出錯。
> - **隱藏複雜代理人(Complexity Hiding)**：用來對一群複雜的類別，進行複雜度隱藏以及存取控制。有時也被稱為**表象代理人(Facade Proxy)**。要注意的是這和[表象模式](http://corrupt003-design-pattern.blogspot.tw/2016/07/facade-pattern.html)是不一樣的，因為代理人控制存取，而表象模式只提供另一組介面。
> - **寫入時複製代理人(Copy-On-Write)**：用來控制物件的複製，將複製的動作拖延到客戶真的需要為止，這是虛擬代理人的變形。可以參考 Java 或 Android 的 CopyOnWriteArrayList 實作。
>
> 以下則是常見實踐
>
> ## **虛擬代理(Virtual Proxy) **
>
> 用比較不消耗資源的代理物件來代替實際物件，實際物件只有在真正需要才會被創造。
> 可以作為⌈延後載入⌋功能的實作，讓資源可以在真正要使用時，才進行載入動作，在其他情況下都只是虛擬代理(Virtual Proxy)所呈現的一個⌈假象⌋。
>
> ```
> 當你擁有一個非常肥大又消耗系統資源的 object service ，然而它又沒有一直啟動的必要（也許特定狀況才會使用到它），這種情況就沒有必要在 App  啟動的時候一起把這個肥大的 object service 建立起來，而可以將建立物件的步驟延後到真正需要使用它的時候。
> 
> 比如使用Web或者視窗程式，在讀取圖片時，會先用＂Loadiing...＂等待畫面給客戶看，當真實圖片載入完成後，再實際顯示給客戶。
> ```
>
> 
>
> ## **遠端代理(Remote Proxy)**
>
> 本地端提供一個代表物件來存取遠端網址的物件。
> 常見於網頁瀏覽器中代理伺服器(Proxy Server)的設定。代理伺服器(Proxy Server)是用來暫存其他不同位址上的網頁伺服器內容。
>
> ```
> 當你要操作的 service object 位於遠端 server 時，由 remote proxy 負責經由 network 傳送 request 給 service  object，這也代表了與 network 溝通的複雜細節就交給 proxy 處理，client 不需要自行 handle 這塊。
> ```
>
> 
>
> ## 保護代理(Protection Proxy)
>
> 限制其他程式存取權限。
> 代理者有職權可以控制是否要真正取用原始物件的資源。
> 常見於網頁瀏覽器中代理伺服器(Proxy Server)的設定。代理伺服器(Proxy Server)是用來暫存其他不同位址上的網頁伺服器內容。
>
> ```
> 這是一個在 web service 中蠻常見的應用，當 request 送出後會先送至 proxy server，proxy 再根據 session 或者 token 判斷 client 是否有權限可以訪問這個資源，同樣的概念也可以用在 web server 以外的許多地方。
> ```
>
> 
>
> ## 智慧型參考(Smart Reference Proxy)
>
> 幫代理的物件增加一些動作(功能)。
>
> ```
> 當物件被參考到時，進行額外的動作，例如計算此物件被參考(呼叫、點擊、下載)的次數。
> ```
>
> 

### 框架應用 AOP(**面向導向程式設計,  Aspect-Oriented Programming**)

> 面向導向設計是一個很有趣的技術與設計架構，它可以允許開發人員在程式執行時期在方法 (method) 中植入共用的一些操作，而且不需要由開發人員自己加，直接在核心系統中註冊就能得到植入操作的功能，最常見的例子就是記錄 (logging)...
>
> ```
> 簡單說，就是在一段程式執行的前、中、後插入其他想執行的程式。
> ```
>
> ```
> 為什麼不直接寫在程式碼裡面就好？
> 假設插入的這段程式碼與原本程式的業務邏輯沒有關系，我們當然不想要修改原本的業務邏輯，為了達到相同的效果，此時就可以採用 AOP 的核心概念。
> ```
>
> [[如何提升系統品質-Day27\]設計 - Aspect-oriented programming(AOP) - iT 邦幫忙::一起幫忙解決難題，拯救 IT 人的一天 (ithome.com.tw)](https://ithelp.ithome.com.tw/articles/10081459)
>
> [[.NET\][Architecture][Design Patterns] 切面導向設計 (Aspect-Oriented Programming, AOP) 的平台實作 (1) - 概念 | 小朱® 的技術隨手寫 - 點部落 (dotblogs.com.tw)](https://dotblogs.com.tw/regionbbs/2014/05/16/aspect_oriented_programming_part_1_concepts)
> 
> 

[莫力全 Kyle Mo]: https://oldmo860617.medium.com/proxy-pattern-5f89595dcd30
[Code Paradise]: http://glj8989332.blogspot.com/2018/04/design-pattern-proxy-pattern.html
[深入淺出設計模式 (Head First Design Patterns) 的筆記]: http://corrupt003-design-pattern.blogspot.com/2016/10/proxy-pattern.html

[自己不會沒關係～找一個代理人幫忙處理 - 代理模式 ( Proxy Pattern )]: https://ithelp.ithome.com.tw/articles/10205659

