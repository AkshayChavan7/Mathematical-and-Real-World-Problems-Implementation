#Numerical Integration using Simpson's Rule


#f(x)=1/(x+1)
def f(x):
    return (1/(x+1))


#function to calculate sum of odd position numbers excluding lower limit
def sum_odds(l,n):
    sum=0
    for i in range(0,n):
        if i%2==1:
            #print('i:',i,' l[i]',l[i])
            sum+=l[i]
    return sum

#function to calculate sum of even position numbers excluding upper limit
def sum_even(l,n):
    sum=0
    for i in range(2,n-1):
        if i%2==0:
            #print('i:',i,' l[i]',l[i])
            #print(i)
            sum+=l[i]
    return sum

    
def simpson(a,b,n,I):

    del_x=(b-a)/n           #interval length
    #print(del_x)

    y=[]                    #list of interval points

    i=a
    t=0
    
    while t<=(n-1):
        i=f(a+(t*del_x))
        #print(i)
        y.append(i)
        t+=1
    y.append(f(b))
    print('\nInterval List(y): ',y)
    #print('even:',sum_even(y,len(y)))
    t1=del_x/3
    t2=y[0]+4*(sum_odds(y,len(y)))+2*(sum_even(y,len(y)))+y[4]
    area=t1*t2
    print('\nArea: ',area)
    

simpson(2,3,4,1)


'''
OUTPUT:
Interval List(y):  [0.3333333333333333, 0.3076923076923077, 0.2857142857142857, 0.26666666666666666, 0.25]

Area:  0.28768315018315016
'''
