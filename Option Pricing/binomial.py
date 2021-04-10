#Binomial Option Pricing


def get_probability(spot,rate,volatility):
    u=spot*(1+volatility)
    d=spot*(1-volatility)
    ret=spot*(1+rate)
    return ((ret-d)/(u-d))


def binomial(spot, strike, tenor, rate, volatility):

    pricing_tree=[[spot]]
    payoff_tree=[[]]
    payoff_tree_put=[[]]
    cnt=1
    while cnt<=tenor:
        pricing_tree.append([])
        payoff_tree.append([])
        payoff_tree_put.append([])
        for i in range(0,len(pricing_tree[cnt-1])):
            pricing_tree[cnt].append(round(pricing_tree[cnt-1][i]*(1-volatility),2))
            pricing_tree[cnt].append(round(pricing_tree[cnt-1][i]*(1+volatility),2))
            pricing_tree[cnt]=list(set(pricing_tree[cnt]))
            pricing_tree[cnt].sort(reverse=True)
            #pricing_tree=list(pricing_tree)
        cnt+=1


    print('---------------------Pricing Tree---------------------\n',pricing_tree) 
    
    p=get_probability(spot,rate,volatility)
    q=1-p
    #print(p)

    #print(payoff_tree)
    for i in range(tenor,-1,-1):
        for j in range(i+1):
            if i==tenor:
                if pricing_tree[i][j]>strike:
                    payoff_tree[i].insert(j,round(pricing_tree[i][j]-strike,2))
                    payoff_tree_put[i].insert(j,0)
                else:
                    payoff_tree_put[i].insert(j,round(strike-pricing_tree[i][j],2))
                    payoff_tree[i].insert(j,0)
            else:
                temp=((p*payoff_tree[i+1][j])+(q*payoff_tree[i+1][j+1]))/(1+rate)
                temp_put=((p*payoff_tree_put[i+1][j])+(q*payoff_tree_put[i+1][j+1]))/(1+rate)               
                payoff_tree[i].insert(j,round(temp,2))
                payoff_tree_put[i].insert(j,round(temp_put,2))
                        
                
    
    print('\n\n---------------------Payoff Tree Call---------------------\n',payoff_tree)

    print('\n\nCall option price:',payoff_tree[0][0])

    print('\n\n---------------------Payoff Tree Put---------------------\n',payoff_tree_put)

    print('\n\nPut option price:',payoff_tree_put[0][0])

    

binomial(100,110,2,0.1,0.20)


'''
OUTPUT:
---------------------Pricing Tree---------------------
 [[100], [120.0, 80.0], [144.0, 96.0, 64.0]]


---------------------Payoff Tree Call---------------------
 [[15.8], [23.18, 0.0], [34.0, 0, 0]]


Call option price: 15.8


---------------------Payoff Tree Put---------------------
 [[6.71], [3.18, 20.0], [0, 14.0, 46.0]]


Put option price: 6.71
'''
