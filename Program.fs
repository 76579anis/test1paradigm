open System

// Initial list of salaries
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Initial Salaries: %A" salaries

// 1. 
let highIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000)
printfn "Salaries above $100,000 (High-income salaries): %A" highIncomeSalaries

// 2. 
printfn "Initial Salaries: %A" salaries
let calculateTax salary =
    match salary with
    | s when s <= 49020 -> float s * 0.15 // 15%
    | s when s <= 98765 -> float s * 0.20 // 20%
    | _ -> float salary * 0.30 // 30%

let taxedSalaries = salaries |> List.map calculateTax
printfn "Tax for each salary: %A" (List.zip salaries taxedSalaries)

// 3.
printfn "Initial Salaries: %A" salaries
let updatedSalaries = salaries |> List.map (fun salary -> if salary < 49020 then salary + 20000 else salary)
printfn "Salaries after adding $20,000 to low-income salaries: %A" updatedSalaries

// 4. 
printfn "Initial Salaries: %A" salaries
let filteredSalaries = salaries |> List.filter (fun salary -> salary >= 50000 && salary <= 100000)
printfn "Salaries between $50,000 and $100,000: %A" filteredSalaries

printfn "Initial Salaries: %A" salaries
let sumOfFilteredSalaries = filteredSalaries |> List.reduce (+)
printfn "Sum of salaries between $50,000 and $100,000: %d" sumOfFilteredSalaries


let rec sumMultiplesOfThree n acc =
    if n = 0 then acc
    else sumMultiplesOfThree (n - 3) (acc + n)


let result = sumMultiplesOfThree 27 0
printfn "Sum of multiples of 3 up to 27: %d" result


