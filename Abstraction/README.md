<h1> Абстрактные классы. </h1>
 
· Абстракция — в объектно-ориентированном программировании это придание объекту характеристик, которые отличают его от всех других объектов, четко определяя его концептуальные границы. Основная идея состоит в том, чтобы отделить способ использования составных объектов данных от деталей их реализации, в виде более простых объектов, подобно тому, как функциональная абстракция разделяет способ использования функции и деталей её реализации, в терминах более примитивных функций, таким образом, данные обрабатываются функцией высокого уровня с помощью вызова функций низкого уровня. </br>
· Абстрактный класс в объектно-ориентированном программировании — базовый класс, который не предполагает создания экземпляров. Абстрактные классы реализуют на практике один из принципов ООП - полиморфизма. Абстрактный класс может содержать (и не содержать) абстрактные методы и свойства. Абстрактный метод не реализуется для класса, в котором описан, однако должен быть реализован для его неабстрактных потомков. Абстрактные классы представляют собой наиболее общие абстракции, то есть имеющие наибольший объем и наименьшее содержание. </br>
· Ключевое слово abstract может использоваться с классами, методами, свойствами, индексаторами и событиями.  </br>
· Ключевое слово abstract при создании класса указывает, что класс предназначен только для использования в качестве базового класса для других классов. Члены, помеченные как абстрактные или включенные в абстрактный класс, должны быть реализованы с помощью классов, производных от абстрактных классов.</br>

· Возможности абстрактных классов:

1) Экземпляр абстрактного класса создать нельзя 
2) Абстрактные классы могут содержать как абстрактные, так и обыкновенные (неабстрактные) члены. 
3) Неабстрактный класс, являющийся производным от абстрактного, должен содержать фактические реализации всех наследуемых абстрактных методов и методов доступа.</br>

· Возможности абстрактных методов: 

1) Абстрактный метод является неявным виртуальным методом. </br>
2) Создание абстрактных методов допускается только в абстрактных классах. </br>
3) Тело абстрактного метода отсутствует; создание метода просто заканчивается двоеточием, а после сигнатуры ставить фигурные скобки ({ }) не нужно </br>
4) Реализация предоставляется методом переопределения override, который является членом неабстрактного класса. </br>
· Абстрактный класс должен предоставлять реализацию для всех членов интерфейса. </br>
· Абстрактный класс, реализующий интерфейс, может отображать методы интерфейса в абстрактных методах. </br>
· Преимущества использования абстрактных классов: </br>
1) Общий код в одной реализации в виде конкретных и абстрактных членов 
2) Изменение значения полей или неабстрактных членов абстрактного класса приводит к соответствующему изменению во всех его производных классах.</br>
3) Наличие реализации по умолчанию. </br>
