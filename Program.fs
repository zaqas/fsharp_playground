open System    

module printf_sprintf =
    let print_from input_text =
        $"from %s{input_text}"

    let main argv =
        let call_func = print_from "F#"
        printfn $"Hello world %s{call_func}"
        0

// How to make a variable mutable
module var_mutability =
    let mutable name = "Chris"
    name <- "Albert"
    printf "My name: %s" name  

// Print value of integer using format specifiers
module calcultaor =
    let main argv =
        printfn "Hello user, welcome to the calculator!"
        let sum = 0
        printfn "The sum is equal to: %i" sum
        0
// Find the bug within this code and fix it 
module check_specifier =
        let main argv =
        let aNumber = 0
        // Issue was using wrong format specifier
        printfn "Here is a number %i" aNumber
        0


// Write a program that gets a string from the user and converts it into integer
module get_input_convert_2_int =
    Console.WriteLine("Enter number")
    let str = Console.ReadLine()
    let converted_val = int str
    printfn $"{converted_val}"

// Write a program that gets an input from the user, checks whether it is divisable by 2
module checkIfDivisableBy2 = 
    printfn "Enter value:"
    let n = Console.ReadLine()
    let isDivisableBy2 = int n % 2 = 0

    printfn $"Is it divisable by 2? {isDivisableBy2}"


// Write a calculator that given two inputs from user, sums them up
module calculator_sum_op = 
    printfn "Welcome to the calculator program"

    printfn "Enter first value to calculate:"
    let first_number = Console.ReadLine()

    printfn "Enter second value to calculate:"
    let second_number =  Console.ReadLine()
        
    let sum = int(first_number) + int(second_number)
    printfn $"The first number is {first_number}, and the second number is {second_number}"
    printfn "The sum is %i" sum

// Write a program that using if-else checks if citizen is older than 50 is senior,
// otherwise normal citizen
module if_condition_check = 
    printfn "Please enter your age:"
    let age = int(Console.ReadLine())

    if age > 50 then printfn "Hello old citizen" else printfn "Hello not so old citizen"

// If cards value is equal to 1 or 14 is Ace otherwise "a card"
module card_description = 
    let card_value = 1
    let card_desc = if card_value = 1 then "Ace" elif card_value = 14 then "Ace" else "a card"
    printfn $"Card is: {card_desc}"

// Write a program that given a card number, generates its description

module card_description2 = 
    let card_number = 14

    let m =
        if card_number = 14 || card_number = 1 then "Ace"
        elif card_number = 13 then "King"
        elif card_number = 12 then "Queen"
        elif card_number = 11 then "Jack"
        else string card_number

    printfn $"Card description: {m}" 

// Write a program that given a card number,
// generates its description (here we use pattern matching instead)

module generate_description = 
    let card_number = 14

    let m =
        match card_number with
        | 14 -> "Ace"
        | 13 -> "King"
        | 12 -> "Queen"
        | 11 -> "Jack"
        | _ -> string card_number
        
    printfn "%s" m

// Write a program that given a list, iterates over all elements and prints it out

module iter_list = 
    let my_list = [1;3;4;5]

    for m in my_list do
        printf $"{m}"

// Write a program that prints out numbers from 1 to 20 using for loop
module print_loop_to = 
    for i = 1 to 20 do
        printfn $"{i}"

// Write a program that prints out numbers from 20 to 1 using for loop
module print_loop_downto = 
    for i = 20 downto 12 do
        printfn $"{i}"
        
// Implement guessing game in f#
module guessing =
    let number = 12
    let mutable cond = false

    while not cond do
        printfn "Please enter your guess:"
        let user_input = int(Console.ReadLine())
        if user_input = number then
            printfn "Correct guess!"
            cond <- true
        else
            printfn "False guess!"

// Generate a list of random values
module generate_list_of_random_nums = 
    let my_list_of_rand = [for i in 0..51 do Random().Next(1..52)]


module card_game = 
    // Build a deck of cards for a card game in F#
    let card_description card =
        let card_num = card % 13
        match card_num with
        | card_num when card_num = 1 -> "Ace"
        | card_num when card_num = 11 -> "Jack"
        | card_num when card_num = 12 -> "Queen"
        | card_num when card_num = 0 -> "King"
        | _ -> string(card_num)

    let suit num=
        let suit_num = num / 13
        match suit_num with
            | suit_num when suit_num = 0 -> "Hearts"
            | suit_num when suit_num = 1 -> "Spades"
            | suit_num when suit_num = 2 -> "Diamonds"
            | suit_num when suit_num = 3 -> "Clubs"

    [<EntryPoint>]
    let main argv =
        // deck of cards
        let cards = [for i in 0..51 do Random().Next(1,52)]
        printfn "My list: %A" cards

        for card in cards do
            printfn "%s of %s" (card_description(card)) (suit(card))
        0    
        
    
    
    
    