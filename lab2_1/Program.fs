//Бушуев Никита Николаевич БАС-1(2024)
//Вариант 2
open System

let readList() =
    printf "Введите количество элементов: "
    let n = int(Console.ReadLine())
    
    let rec readElements acc count =
        if count = 0 then
            List.rev acc
        else
            printf "Введите элемент %d: " (n - count + 1)
            let x = int(Console.ReadLine())
            readElements (x::acc) (count - 1)
    
    readElements [] n

let lastDigit x = abs x % 10

[<EntryPoint>]
let main argv =

    let numbers = readList()
    printfn "Исходный список: %A" numbers
    
    let lastDigits = List.map lastDigit numbers
    printfn "Последние цифры: %A" lastDigits
    
    0