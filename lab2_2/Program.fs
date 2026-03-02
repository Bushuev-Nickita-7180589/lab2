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

[<EntryPoint>]
let main argv =
    let numbers = readList()
    printfn "Исходный список: %A" numbers
    
    printf "Введите цифру (0-9), на которую должны оканчиваться элементы: "
    let digit = int(Console.ReadLine()) % 10
    
    let sum = 
        List.fold (fun acc x -> 
            if x % 10 = digit then 
                acc + x 
            else 
                acc 
        ) 0 numbers
    
    printfn "Сумма элементов, оканчивающихся на %d: %d" digit sum
    
    0