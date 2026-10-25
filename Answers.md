# Session 07 – Answers

## Part 1
**Q3** – `shape.Area()` = 6. `cube.Area()` = 24. `shapeRef.Area()` = **6**.
`shapeRef` نوعه `Shape`، و`Area()` في Shape مش `virtual`، و`Cube` عملت لها `new` (Hiding). الـ compiler بيختار
الميثود وقت الـ compile حسب **نوع المتغير** (Shape) مش نوع الـ Object، ده اسمه **Static / Early Binding**.

**Q4** – بيشتغل `Shape.ToString()` (Cube ورثتها ومعملتش لها override) ويطبع `(Width = 1, Height = 2)`.
ده **Dynamic / Late Binding**: `ToString` في `object` معمولة `virtual`، فالـ CLR بيشوف نوع الـ Object الحقيقي وقت التشغيل
وينده آخر override. `Area()` ماكانتش virtual فمفيش Dynamic Binding.

## Part 2
**Q7** – `Greet()` بتطبع نسخة Person ("I am a Person.") لأنها non-virtual + `new` → Static Binding (compile time).
`Display()` بتطبع نسخة Doctor/Engineer لأنها virtual + override → Dynamic Binding (run time).

**Q8** – لو شلت `virtual` من `Display()`: error `CS0506: 'Doctor.Display()': cannot override inherited member
'Person.Display()' because it is not marked virtual, abstract, or override`.
يعني: مينفعش تعمل override لميثود الأب ما سمحش بيها.

## Part 3
**Q9** – لو عملنا Class واحد بـ 4 ميثودز، العربية هتتجبر تنفذ `MoveUp/MoveDown` وهي مبتطيرش
(هترمي exception أو تفضل فاضية = تصميم وحش). الـ Interfaces بتخلي كل كلاس ينفذ بس اللي يخصه.

**Q12** – لأ، `planeRef.MoveUp()` مش هتتكتب (compile error) لأن نوع المتغير `IMoveable` ومفيهوش MoveUp.
تحتاج مرجع من نوع `IFlyable` أو `Airplane`، أو cast: `((IFlyable)planeRef).MoveUp()`.

**Q13** – `IVehicle` بيجمع كذا Interface في نوع واحد، فتقدر تتعامل مع الـ 4 methods من مرجع واحد،
وأي كلاس بينفذه لازم ينفذ الكل.

**Q14** – `void IMoveable.MoveForward()` ← مش بتبان على مرجع `Ship` (`ship.MoveForward()` = error).
لازم تنده عليها من خلال Interface: `((IMoveable)ship).MoveForward()` أو `IMoveable r = ship; r.MoveForward();`.

## Part 4
**Q15**

| Feature | Static Binding (`new`) | Dynamic Binding (`override`) |
|---|---|---|
| Keyword in base | مفيش (أي ميثود) | `virtual` (أو abstract / override) |
| Keyword in derived | `new` | `override` |
| Resolved at | Compile time | Run time |
| Behavior via base reference | بتشتغل نسخة الـ Base | بتشتغل نسخة الـ Derived |

**Q16** – `virtual` معناها إن كاتب الـ Base سمح إن الميثود دي تتغير وبيعمل ليها dispatch وقت التشغيل،
فـ `override` محتاجة الإذن ده. أما `new` فهي مجرد ميثود جديدة بنفس الاسم بتخفي القديمة؛
مبتغيرش سلوك الـ Base لحد بيستخدم نوع الـ Base، فمش محتاجة إذن.
