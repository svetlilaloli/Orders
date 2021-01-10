Console Application<br/>
Exercise: Associative Arrays<br/>

# Orders
Write a program that keeps information about __products__ and their __prices__. Each product has a __name__, a __price__ and a __quantity__. If the product __doesn’t exist__ yet, __add__ it with its __starting quantity__.<br/>
If you receive a product, which __already exists__, __increase__ its quantity by the input quantity and if its __price__ is different, __replace__ the price as well.<br/>
You will receive products’ __names__, __prices__ and __quantities__ on __new lines__. Until you receive the command "__buy__", keep adding items. When you do receive the command "__buy__", print the items with their __names__ and __total price__ of all the products with that name. 
## Input
* Until you receive "__buy__", the products will be coming in the format: "__{name} {price} {quantity}__".
* The product data is __always__ delimited by a __single space__.
## Output
* Print information about each product in the following format:<br/> 
"__{productName} -> {totalPrice}__"
* __Format__ the average grade to the __2nd digit after the decimal separator__.
## Examples
Input|Output
-----|------
Beer 2.20 100<br/>IceTea 1.50 50<br/>NukaCola 3.30 80<br/>Water 1.00 500<br/>buy|Beer -> 220.00<br/>IceTea -> 75.00<br/>NukaCola -> 264.00<br/>Water -> 500.00
Beer 2.40 350<br/>Water 1.25 200<br/>IceTea 5.20 100<br/>Beer 1.20 200<br/>IceTea 0.50 120<br/>buy|Beer -> 660.00<br/>Water -> 250.00<br/>IceTea -> 110.00
CesarSalad 10.20 25<br/>SuperEnergy 0.80 400<br/>Beer 1.35 350<br/>IceCream 1.50 25<br/>buy|CesarSalad -> 255.00<br/>SuperEnergy -> 320.00<br/>Beer -> 472.50<br/>IceCream -> 37.50
