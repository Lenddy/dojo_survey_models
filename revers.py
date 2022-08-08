# def solution(string):
#     # some_list = []
#     for i in string:
#         # some_list.append(i)
#         print(i)
#         # print(some_list)
#         for r in  string:
#             print(len(string))



# solution("hello")



#  Python3 program to reverse individual words
# in a given string using STL list
 
# reverses individual words of a string
def reverseWords(string):
    st = list()
 
    # Traverse given string and push all characters
    # to stack until we see a space.
    for i in range(len(string)):
        if string[i] != " ":
            st.append(string[i])
 
        # When we see a space, we print
        # contents of stack.
        else:
            while len(st) > 0:
                print(st[-1], end= "")
                st.pop()
            print(end = " ")
 
    # Since there may not be space after
    # last word.
    while len(st) > 0:
        print(st[-1], end = "")
        st.pop()
 
    
string = input("enter a word ")
reverseWords(string)

# This code is contributed by
# sanjeev2552