#Numerical Differentiation using Newton's Backward Interpolation

import math

#mul will give p*(p+1) for n times
def mul(p,n):
    temp=p
    for i in range(1,n):
        p=(p*(temp+1))
        #print('P :',p)
        temp+=1
    return p

#x[] is input points list and pt is point for which output is to be found
def backward_interpolation(x,y,pt):

    #calculating backward difference table
    diff=[]
    
    n=len(y)
    for temp in range(0,n):
        diff.append([])         #creating empty list to store backward differences

    cnt=1
    diff[0]=y
    n_diff=len(y)

    while cnt<=n-1:
        #print('cnt:',cnt)
        for i in range(0,n_diff-1):
            #print('i:',i)
            diff[cnt].append(diff[cnt-1][i+1]-diff[cnt-1][i])
        n_diff=len(diff[cnt])
        cnt+=1


    #printing forward difference table
    print('--------------------Backward Difference Table--------------------')
    for i in range(1,n):
        print('Del^',i,'.y0',' :', diff[i])
    print('----------------------------------------------------------------')

    
    #to find P
    h=x[1]-x[0]         #h=step size
    x0=x[n-1]
    print('h :',h)
    
    for i in range(0,n):
        if pt<=x[i]:
            x0=x[i]   #x0 immediate next value of x
            break
    #p=(x-x0)/h
    print('x0 :',x0)
    p=(pt-x0)/h
    #print('x0: ',x0)
    print('p: ',p)

    #finding position of x to find f(x)
    pos=n-1
    '''
    for i in range(0,n):
        if x0==x[i]:
            pos=i
            break
    '''
    fx=diff[0][pos]
    #print(fx)
    sum=0
    for i in range(0,n):
        leng=len(diff[i])
        print('mul :',mul(p,i),'del: ',diff[i][leng-1])
        sum+=((mul(p,i)*diff[i][leng-1])/math.factorial(i))

    print('sum: ',sum)
    answer=fx+sum

    print('Value at point',pt,'is =',answer)
    

#TEST CASE 1
x=[1891,1901,1911,1921,1231]
y=[46,66,81,93,101]
n=1925
#TEST CASE 2
#x=[45,50,55,60]
#y=[0.7071,0.7660,0.8192,0.8660]
#n=52
backward_interpolation(x,y,n)    
#print('mul: ',mul(0.6,0))

'''
OUTPUT:
--------------------Forward Difference Table--------------------
Del^ 1 .y0  : [0.6000000000000001, 2.1999999999999997, 4.3999999999999995, 7.200000000000001]
Del^ 2 .y0  : [1.5999999999999996, 2.1999999999999997, 2.8000000000000016]
Del^ 3 .y0  : [0.6000000000000001, 0.6000000000000019]
Del^ 4 .y0  : [1.7763568394002505e-15]
----------------------------------------------------------------

Value at point 3 is = 1.2016
'''
